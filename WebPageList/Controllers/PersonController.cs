using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPagination.Data.Repositories;
using WebPagination.Models;

namespace WebPagination.Controllers
{
    public class PersonController : Controller
    {

        private readonly IPersonRepository _PersonRepository;
        private readonly IPhoneRepository _IPhoneRepository;

        public PersonController(IPersonRepository IPersonRepository, IPhoneRepository IPhoneRepository)
        {
            _PersonRepository = IPersonRepository;
            _IPhoneRepository = IPhoneRepository;
        }

        // GET: PersonController
        public async Task<IActionResult> Index()
        {
            return View( await GetPersonsAsync(1));
        }
        [HttpPost]
        public async Task<IActionResult> Index(int currentPageIndex)
        {
            return View( await GetPersonsAsync(currentPageIndex));
        }

        private async Task<PersonModel> GetPersonsAsync(int currentPage)
        {
            int maxRows = 3;
            var person = await _PersonRepository.Obter();
            double pageCount = (double)((decimal)person.Count() / Convert.ToDecimal(maxRows));
            PersonModel personModel = new()
            {
                peoples = person.Skip(currentPage - 1).Take(maxRows).ToList(),
                PageCount = (int)Math.Ceiling(pageCount),
                CurrentPageIndex = currentPage
            };

            return personModel;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPerson()
        {
            var person = new Person( 1, "FirstName", "LastName");
            await _PersonRepository.AddAsync(person);
            return Ok(person);
        }
    }
}

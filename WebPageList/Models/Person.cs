using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPagination.Models
{
    public class Person
    {
        [Key]
        public int BusinessEntityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(int businessEntityID, string firstName, string lastName)
        {
            this.BusinessEntityID = businessEntityID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

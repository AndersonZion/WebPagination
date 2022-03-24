


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPagination.Models
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        public string Name { get; set; }
    }
}

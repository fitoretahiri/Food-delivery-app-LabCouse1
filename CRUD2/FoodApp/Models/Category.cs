using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Category
    {
        [Key]
        public int userID { get; set; }
        public string emri { get; set; }
        public string mbiemri { get; set; }
        public string photoProfile { get; set; }
        public string roli { get; set; }

    }
}

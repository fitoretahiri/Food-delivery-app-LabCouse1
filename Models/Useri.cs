using System.ComponentModel.DataAnnotations;

namespace Food_delivery_app_LabCouse1.Models
{
    public class Useri
    {
        [Key]
        public int userID { get; set; }
        public string emri { get; set; }
        public string mbiemri { get; set; }
        public string photoProfile { get; set; }
        public string roli { get; set; }

    }
}
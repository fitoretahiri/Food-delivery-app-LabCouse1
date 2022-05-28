using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_delivery_app_LabCouse1.Models
{
    public class Useri
    {
        [Key]
        public int userID { get; set; }
        public string emri { get; set; }
        public string mbiemri { get; set; }
        public string photoProfile { get; set; }
        public string password { get; set; }
        public string confirmPsw { get; set; }
        public int roliID { get; set; }
        [ForeignKey("roliID")]
        public Roli roli { get; set; }

    }
}
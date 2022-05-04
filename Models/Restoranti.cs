using System;
namespace Food_delivery_app_LabCouse1.Models
{
    public class Restoranti
    {
        public int Id { get; set; }

        public string emri { get; set; }

        public string qyteti { get; set; }

        public string adresa { get; set; }

        public string nr_kontaktues { get; set; }

        public DateTime data_regjistrimit { get; set; }
    }
}

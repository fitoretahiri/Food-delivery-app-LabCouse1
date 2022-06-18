using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Food_delivery_app_LabCouse1.Models
{
    public class Qyteti

    {
        [Key]
        public int QytetiID { get; set; }

        public string Emri { get; set; }
    }
}

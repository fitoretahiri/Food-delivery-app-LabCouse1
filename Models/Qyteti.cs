using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> login_functionality_branch

namespace Food_delivery_app_LabCouse1.Models
{
    public class Qyteti

    {
        [Key]
        public int QytetiID { get; set; }

<<<<<<< HEAD
        public string Emri { get; set; }
=======
        public string emri { get; set; }

        public List<Restaurant_Qyteti> Restaurant_Qyteti { get; set; }
>>>>>>> login_functionality_branch
    }
}

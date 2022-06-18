using System;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> login_functionality_branch
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_delivery_app_LabCouse1.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string Emertimi { get; set; }
        public string Pershkrimi { get; set; }
        public double Cmimi { get; set; }

        public int Nr_artikujve { get; set; }
        public bool isAvailable { get; set; }
        //lidhja e tabeles menu me tabelen restaurant
        public int RestaurantID { get; set; }
        [ForeignKey("RestaurantID")]
        public Restauranti Restauranti { get; set; }

        public int PijaID { get; set; }
        [ForeignKey("PijaID")]
        public Pija Pija { get; set; }
        public int UshqimiID { get; set; }
        [ForeignKey("UshqimiID")]
        public Ushqimi Ushqimi { get; set; }

<<<<<<< HEAD
=======
        public int nr_artikujve { get; set; }
        //lidhja e tabeles menu me tabelen restaurant
        public int restaurantID { get; set; }
        [ForeignKey("restaurantID")]
        public Restaurant restaurant { get; set; }
>>>>>>> login_functionality_branch
    }
}

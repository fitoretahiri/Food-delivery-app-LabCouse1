using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Food_delivery_app_LabCouse1.Models
{
    public class Pagesa
    {
        [Key]
        public int PagesaId { get; set; }
        public string UserId { get; set; }
       // public double CmimiTotal { get; set; }
        public int PorosiaId { get; set; }



        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }

        [ForeignKey(nameof(PorosiaId))]
        public Porosia Porosia { get; set; }

    }
}

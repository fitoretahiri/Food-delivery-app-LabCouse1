using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Food_delivery_app_LabCouse1.Models
{
    public class Transportuesi
    {
        [Key]
        public int transportuesiID { get; set; }
        public int nrPorosive { get; set; }
        public DateTime dataLindjes { get; set; }
        public int statusi_aktivitetit { get; set; }
        public int perdoruesiID { get; set;}
        [ForeignKey("perdoruesiID")]
        public Perdoruesi perdoruesi { get; set; }

    }
}

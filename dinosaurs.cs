using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Data
{
    public class dinosaurs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DinoID { get; set; }
        [Display(Name ="Dinosaur name")]
        public string DName { get; set; }
        [Display(Name ="Exhibit Number")]
        public int Enumber{ get; set; }

        [ForeignKey("Enumber")]
        public exhibits Etypes { get; set; }
    }
}

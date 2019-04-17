using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
    public class Hastaneler
    {
        [Key]
        public int HastanelerID { get; set; }
        public string HastaneAdı { get; set; }
        public int? IlcelerID { get; set; }
        public int? IllerID { get; set; }
        public List<Doktorlar> Doktorlars { get; set; }
        public Ilceler Ilceler { get; set; }
        public List<Klinikler> Kliniklers { get; set; }
    }
}

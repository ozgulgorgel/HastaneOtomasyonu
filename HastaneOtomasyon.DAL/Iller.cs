using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
   public class Iller
    {
        [Key]
        public int IllerID { get; set; }
        public string Il { get; set; }

        public  List<Ilceler> Ilcelers { get; set; }
        public  List<Hastaneler> Hastanelers { get; set; }
    }
}

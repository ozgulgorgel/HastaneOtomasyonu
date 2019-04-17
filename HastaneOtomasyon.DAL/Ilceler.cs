using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
   public class Ilceler
    {
        [Key]
        public int IlcelerID { get; set; }
        public int? IllerID { get; set; }
        public Iller Iller { get; set; }
        public string Ilce { get; set; }
       

    }
}

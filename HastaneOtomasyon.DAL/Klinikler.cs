using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
   public class Klinikler
    {
       [Key]
        public int KliniklerID { get; set; }
        public string KlinikAdı { get; set; }
        public int? HastanelerID { get; set; }
        public List<Doktorlar>  Doktorlars  { get; set; }
        public List<Randevular> Randevulars { get; set; }

      
    }
}

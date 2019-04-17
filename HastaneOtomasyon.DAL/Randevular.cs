using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
   
    public  class Randevular
    {
        [Key]
        public int RandevularID { get; set; }
        //[ForeignKey("DoktorlarId")]
        public int? DoktorlarId { get; set; }
        public  Doktorlar Doktorlar { get; set; }
      
        //[ForeignKey("HastanelerID")]
        public int? HastanelerID { get; set; }
        public  Hastaneler Hastaneler { get; set; }
        public int? KliniklerID { get; set; }
        public  Klinikler Klinikler { get; set; }
       
    }
}

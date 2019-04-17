using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
   public class Doktorlar
    {
        public int DoktorlarId { get; set; }
        public string Adı { get; set; }
        public string Unvan { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public int? KliniklerID { get; set; }
        public int? HastanelerID { get; set; }
        public List<Randevular> Randevulars { get; set; }
    }
}


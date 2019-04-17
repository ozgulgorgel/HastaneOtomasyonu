using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
    public class Hastalar
    {
        [Key]
        public int TCNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Telefon { get; set; }
        public string email { get; set; }
        public string cinsiyet { get; set; }
        public string sifre { get; set; }

    }
}

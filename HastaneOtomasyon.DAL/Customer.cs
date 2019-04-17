using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
   public  class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //[Column(TypeName = "datetime2")]
      
        //public string TC { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        public string Mail { get; set; }
        public string Address { get; set; }
        public string Cardname { get; set; }
        public string Cardnumber { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? Expirydate { get; set; }
        public string Cvccode { get; set; }


    }
}

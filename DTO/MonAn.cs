using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _102190053_LETHIBINH.DTO
{
   public class MonAn
    {
        [Key]
        public int ID_MonAn { get; set; }

        public string TenMonAn { get; set; }
        public ICollection<MonAn_NguyenLieu> monAn_NguyenLieus { get; set; }
        public MonAn()
        {


        }
    }
}

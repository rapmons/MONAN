using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190053_LETHIBINH.DTO
{
    public class NguyenLieu
    {[Key]
        public int ID_NguyenLieu { get; set; }
        public string TenNL { get; set; }
        public bool TT { get; set; }
        public ICollection<MonAn_NguyenLieu> monAn_NguyenLieus { get; set; }
        public NguyenLieu()
        {
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190053_LETHIBINH.DTO
{
   public class MonAn_NguyenLieu
    {
        [Key]
        public string ID { get; set; }

        public int SL { get; set; }
        public string DVtinh { get; set; }
        
        public int ID_MonAn { get; set; }
        [ForeignKey("ID_MonAn")]
        public  MonAn MonAn { get; set; }
        public int ID_NguyenLieu { get; set; }
        [ForeignKey("ID_NguyenLieu")]
        public NguyenLieu NguyenLieu { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190053_LETHIBINH.DTO
{
    class CreateDB : DropCreateDatabaseIfModelChanges<QLM>
    {
        protected override void Seed(QLM context)
        {
            context.MonAns.AddRange(new MonAn[]
            {
                new MonAn {ID_MonAn=1, TenMonAn="mitom"},
                 new MonAn {ID_MonAn=2, TenMonAn="khoaichienxu"}
            });
            context.NguyenLieus.AddRange(new NguyenLieu[]
           {
              new NguyenLieu{ ID_NguyenLieu=1,TenNL="mi",TT=true},
               new NguyenLieu{ ID_NguyenLieu=2,TenNL="khoai",TT=true}
           }) ;
            context.MonAn_NguyenLieus.AddRange(new MonAn_NguyenLieu[]
          {
              new MonAn_NguyenLieu{ID="101",SL= 2,DVtinh="kg",ID_NguyenLieu=1,ID_MonAn=1},
              new MonAn_NguyenLieu{ID="102",SL= 1,DVtinh="kg",ID_NguyenLieu=2,ID_MonAn=2}
              });
        }
    }
}

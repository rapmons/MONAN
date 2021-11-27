using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _102190053_LETHIBINH.DTO;

namespace _102190053_LETHIBINH.BLL
{
    class BLL
    {
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static BLL _Instance;
        public List<MonAn> GetClasses()
        {
            return DAL.DAL.Instance.GetClasses();
        }
        public bool AddStudent(MonAn_NguyenLieu student)
        {
            return DAL.DAL.Instance.AddStudent(student);
        }
        public bool UpdateStudent(MonAn_NguyenLieu student)
        {
            return DAL.DAL.Instance.UpdateStudent(student);
        }
        public List<M_NL_VIEW> GetStudents(int class_ID, string student_Name)
        {
            List<M_NL_VIEW> studentViewModels = new List<M_NL_VIEW>();
            var students = DAL.DAL.Instance.GetStudents(class_ID, student_Name);
            foreach (var s in students)
            { 
                studentViewModels.Add(new M_NL_VIEW
                {
                    STT = Convert.ToInt32(s.ID) ,
                    ten_nguyen_lieu = s.NguyenLieu.TenNL,
                    so_luong = s.SL,
                    dvt = s.DVtinh,
                    tinh_trang = s.NguyenLieu.TT
                });
            }
            return studentViewModels;
        }
    }
}

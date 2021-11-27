using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _102190053_LETHIBINH.DTO;

namespace _102190053_LETHIBINH.DAL
{
    class DAL
    {
        QLM db = new QLM();
        public static DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static DAL _Instance;
        private DAL()
        {

        }

        /// <summary>
        /// Lấy danh sách sinh viên ứng với class_ID và student_Name
        /// </summary>
        /// <param name="class_ID">Mã Lớp</param>
        /// <param name="student_Name">Tên sinh viên</param>
        /// <returns></returns>
        public List<MonAn_NguyenLieu> GetStudents(int class_ID, string student_Name)
        {
            List<MonAn_NguyenLieu> students = new List<MonAn_NguyenLieu>();
            if (class_ID == 0)
            {
                if (student_Name == "")
                {
                    students = db.MonAn_NguyenLieus.Select(p => p).ToList();
                }
                else
                {
                    students = db.MonAn_NguyenLieus.Where(p => p.NguyenLieu.TenNL.Contains(student_Name)).ToList();
                }
            }
            else
            {
                if (student_Name == "")
                {
                    students = db.MonAn_NguyenLieus.Where(p => p.ID_MonAn == class_ID).ToList();
                }
                else
                {
                    students = db.MonAn_NguyenLieus.Where(p => p.ID_MonAn == class_ID &&
                                                p.NguyenLieu.TenNL.Contains(student_Name)).ToList();
                }
            }
            return students;
        }
        
        /// <summary>
        /// Xóa 1 hoặc nhiều sinh viên.
        /// </summary>
        /// <param name="IDs">Danh sách ID của sinh viên được xóa</param>
        /// <returns></returns>
        public bool DeleteStudents(List<string> IDs)
        {
            foreach (var ID in IDs)
            {
                var student = db.MonAn_NguyenLieus.FirstOrDefault(p => p.ID == ID);
                if (student == null)
                    return false;
                else
                {
                    db.MonAn_NguyenLieus.Remove(student);
                }
            }
            db.SaveChanges();
            return true;
        }
        /// <summary>
        /// Lấy thông tin của 1 sinh viên theo ID
        /// </summary>
        /// <param name="ID">ID của sinh viên được lấy thông tin</param>
        /// <returns></returns>
        public MonAn_NguyenLieu GetStudentByID(string ID)
        {
            var student = db.MonAn_NguyenLieus.FirstOrDefault(p => p.ID == ID);
            return student;
        }
        /// <summary>
        /// Cập nhập thông tin của 1 sinh viên
        /// </summary>
        /// <param name="student">Đối tượng sinh viên cần được update</param>
        /// <returns></returns>

        /// <summary>
        /// Lấy danh sách các thuộc tính của sinh viên
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// Kiểm tra xem 'ID' của sinh viên đã tồn tại hay chưa?
        /// </summary>
        /// <param name="ID">ID của sinh viên muốn kiểm tra</param>
        /// <returns>true nếu ID đã tồn tại, ngược lại false</returns>
        public List<MonAn> GetClasses()
        {
            var classes = db.MonAns.Select(p => p).ToList();
            return classes;
        }
        public bool AddStudent(MonAn_NguyenLieu student)
        {
            db.MonAn_NguyenLieus.Add(student);
            db.SaveChanges();
            return true;
        }
        public bool UpdateStudent(MonAn_NguyenLieu student)
        {
            var s = db.MonAn_NguyenLieus.FirstOrDefault(p => p.ID == student.ID);
            if (s == null)
                return false;
            else
            {
                s.SL = student.SL;
                s.DVtinh = student.DVtinh;
                s.ID_MonAn = student.ID_MonAn;
                s.ID_NguyenLieu = student.ID_NguyenLieu;
            }

            db.SaveChanges();
            return true;
        }
    }
}
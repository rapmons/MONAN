using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102190053_LETHIBINH.DTO;

namespace _102190053_LETHIBINH.VIEW
{
    public partial class LeThiBinh_MF : Form
    {
        public LeThiBinh_MF()
        {
            InitializeComponent();
            LoadCBBClass();
            showw();
        }
        public void showw()
        {
            string student_Name = textBox1.Text;
            int class_ID = ((CBBitem)cbb_Class.SelectedItem).Value;
            QLM db = new QLM();
            //  dataGridView1.DataSource = BLL.BLL.Instance.GetStudents(class_ID, student_Name);
            dataGridView1.DataSource = db.MonAn_NguyenLieus.Select(p => new {p.ID, p.NguyenLieu.TenNL, p.SL, p.DVtinh, p.NguyenLieu.TT }).ToList();



        }
        void LoadCBBClass()
        {
            cbb_Class.Items.Add(new CBBitem
            {
                Name = "All",
                Value = 0
            });
            var classes = BLL.BLL.Instance.GetClasses();
            foreach (var c in classes)
            {
                cbb_Class.Items.Add(new CBBitem
                {
                    Name = c.TenMonAn,
                    Value = c.ID_MonAn
                });
            }
            cbb_Class.SelectedIndex = 0;
        }

        private void cbb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            showw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

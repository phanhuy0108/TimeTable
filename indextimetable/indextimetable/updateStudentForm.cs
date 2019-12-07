using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indextimetable
{
    public partial class updateStudentForm : Form
    {
        private int subjectID;
        public updateStudentForm(int id)
        {
            this.subjectID = id;
            InitializeComponent();
            this.Load += UpdateStudentForm_Load;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnSave.Click += BtnSave_Click;
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            var business = new subjectManagerment();
            var oldSubject = business.getSubjects(this.subjectID);
            this.txtCaHoc.Text = oldSubject.CA_HỌC;
            this.txtThu2.Text = oldSubject.Thứ_2;
            this.txtThu3.Text = oldSubject.Thứ_3;
            this.txtThu4.Text = oldSubject.Thứ_4;
            this.txtThu5.Text = oldSubject.Thứ_5;
            this.txtThu6.Text = oldSubject.Thứ_6;
            this.txtThu7.Text = oldSubject.Thứ_7;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            var business = new subjectManagerment();
            var cahoc = this.txtCaHoc.Text;
            var thu2 = this.txtThu2.Text;
            var thu3 = this.txtThu3.Text;
            var thu4 = this.txtThu4.Text;
            var thu5 = this.txtThu5.Text;
            var thu6 = this.txtThu6.Text;
            var thu7 = this.txtThu7.Text;
            business.updateSubject(this.subjectID, cahoc, thu2, thu3, thu4, thu5, thu6, thu7);
            MessageBox.Show("Done");
            this.Close();


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

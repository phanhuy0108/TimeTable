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
    public partial class createSubjectForm : Form
    {
        public createSubjectForm()
        {
            InitializeComponent();
            this.btnSave.Click += BtnSave_Click;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            business.createSubject(cahoc, thu2, thu3, thu4, thu5,thu6,thu7);
            MessageBox.Show("Add new subject successfully");
            this.Close();

        }

        
    }
}

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
    public partial class Form1 : Form
    {
        private subjectManagerment Business;
        public Form1()
        {
            Business = new subjectManagerment();
            InitializeComponent();
            this.Load += Form1_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnSetRemind.Click += BtnSetRemind_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.dataGridView1.DoubleClick += DataGridView1_DoubleClick;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count ==1)
            {
                var subject = (Table)this.dataGridView1.SelectedRows[0].DataBoundItem;
                var updateForm = new updateStudentForm(subject.ID);
                updateForm.ShowDialog();
                this.loadAllSubject();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSetRemind_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var createSubjectForm = new createSubjectForm();
            createSubjectForm.ShowDialog();
            this.loadAllSubject();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadAllSubject();
        }
        private void loadAllSubject()
        {
            var subject = this.Business.getSubject();
            this.dataGridView1.DataSource = subject;
        }
    }
}

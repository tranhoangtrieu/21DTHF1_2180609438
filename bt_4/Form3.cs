
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //Model1 context = new Model1();
            //List<Student> students = context.Students.ToList();
            //List<StudentReport> listReport = new List<StudentReport>();
            //foreach (Student i in students)
            //{
            //    StudentReport temp =new StudentReport();
            //    temp.StudentID = i.StudentID;
            //    temp.FullName = i.FullName;
            //    temp.AverageScore = i.AverageScore;
                
            //    temp.FacultyName = i.Faculty.FacultyName;
            //    listReport.Add(temp);
            //}
            //this.reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            //var reportDataSource = new ReportDataSource("StudentDataSet", listReport);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            ////this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //this.reportViewer1.RefreshReport();

        }
    }
}

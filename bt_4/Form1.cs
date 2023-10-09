using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 student = new Model1();
                List<Faculty> listFalcultys = student.Faculties.ToList();
                List<Student> listStudents = student.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudents);
            }
            catch
            {

            }

        }

        public void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.comboBox1.DataSource = listFacultys;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyID";
            }

        

        public void BindGrid(List<Student> students)
    {
        dataGridView1.Rows.Clear();
            foreach (var item in students) {
            int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;


            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 student = new Model1();

               
                Faculty selectedFaculty = (Faculty)comboBox1.SelectedItem;

               
                Student newStudent = new Student
                {
                    StudentID = textBox1.Text,
                    FullName = textBox2.Text,  
                    AverageScore = Convert.ToDouble(textBox3.Text),  
                    FacultyID = selectedFaculty.FacultyID
                };

               
                student.Students.Add(newStudent);
                student.SaveChanges();

               
                List<Student> listStudents = student.Students.ToList();
                BindGrid(listStudents);
                MessageBox.Show("Thêm thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 student = new Model1();              
                string studentID = textBox1.Text;               
                Student selectedStudent = student.Students.FirstOrDefault(s => s.StudentID == studentID);
              
                selectedStudent.FullName = textBox2.Text; 
                selectedStudent.AverageScore = Convert.ToDouble(textBox3.Text); 
              
                student.SaveChanges();

           
                List<Student> listStudents = student.Students.ToList();
                BindGrid(listStudents);
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 student = new Model1();
                string studentID = textBox1.Text;          
                Student selectedStudent = student.Students.FirstOrDefault(s => s.StudentID == studentID);
            
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                 
                    student.Students.Remove(selectedStudent);
                    student.SaveChanges();
                    MessageBox.Show("Xoa sinh vien thanh cong");
                    List<Student> listStudents = student.Students.ToList();
                    BindGrid(listStudents);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}

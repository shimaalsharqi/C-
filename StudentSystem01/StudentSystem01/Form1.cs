using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentSystem01
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // Student class
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Grade { get; set; }
        }

        // Load
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

           
            dataGridView1.AllowUserToAddRows = false;

            // ربط حدث الضغط
            dataGridView1.CellClick += dataGridView1_CellClick;

            RefreshGrid();
        }

        // Refresh Grid
        void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        // ADD
        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            double grade;

            if (int.TryParse(txtAge.Text, out age) &&
                double.TryParse(txtGrade.Text, out grade))
            {
                students.Add(new Student
                {
                    Name = txtName.Text,
                    Age = age,
                    Grade = grade
                });

                RefreshGrid();

                txtName.Clear();
                txtAge.Clear();
                txtGrade.Clear();
            }
            else
            {
                MessageBox.Show("Enter valid numbers!");
            }
        }

        // DELETE
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = null;

                if (dataGridView1.CurrentRow != null &&
                    !dataGridView1.CurrentRow.IsNewRow &&
                    dataGridView1.CurrentRow.DataBoundItem != null)
                {
                    student = (Student)dataGridView1.CurrentRow.DataBoundItem;
                }
                else
                {
                    student = students.Find(s => s.Name == txtName.Text);
                }

                if (student != null)
                {
                    students.Remove(student);
                    RefreshGrid();
                    MessageBox.Show("Student Deleted");
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // SEARCH
        private void button3_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            Student result = students.Find(s => s.Name == name);

            if (result != null)
            {
                MessageBox.Show(
                    $"Found:\nName: {result.Name}\nAge: {result.Age}\nGrade: {result.Grade}");
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtGrade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            }
        }
    }
}
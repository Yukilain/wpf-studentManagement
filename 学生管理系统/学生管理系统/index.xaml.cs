using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Messaging;

namespace 学生管理系统
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public partial class index : Window
    {
        private string connectionString = "server=.;database=StuData;uid=sa;pwd=123456"; 
        private ObservableCollection<Student> students = new ObservableCollection<Student>();

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public Student SelectedStudent { get; set; }
        public index()
        {
            InitializeComponent();
            DataContext = this;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT Id, Name, Age, Grade,Sex FROM Students", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student = new Student()
                        {
                            Id = reader["Id"] != DBNull.Value ? (int)reader["Id"] : 0,
                            Name = reader["Name"].ToString(),
                            Age = (int)reader["Age"],
                            Grade = reader["Grade"].ToString(),
                            Sex= reader["Sex"].ToString()
                        };

                        students.Add(student);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO Students (Name, Age, Grade,Sex) VALUES (@Name, @Age, @Grade, @Sex)", conn);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    command.Parameters.AddWithValue("@Grade", txtGrade.Text);
                    command.Parameters.AddWithValue("@Sex", txtSex.Text);
                    command.ExecuteNonQuery();

                    students.Clear();
                    LoadData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SelectedStudent != null)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand command = new SqlCommand("DELETE FROM Students WHERE Id = @Id", conn);
                        command.Parameters.AddWithValue("@Id", SelectedStudent.Id);

                        command.ExecuteNonQuery();

                        students.Remove(SelectedStudent);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SelectedStudent != null)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand command = new SqlCommand("UPDATE Students SET Name = @Name, Age = @Age, Grade = @Grade, Sex=@Sex WHERE Id = @Id", conn);
                        command.Parameters.AddWithValue("@Id", SelectedStudent.Id);
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                        command.Parameters.AddWithValue("@Grade", txtGrade.Text);
                        command.Parameters.AddWithValue("@Sex", txtSex.Text);
                        command.ExecuteNonQuery();

                        SelectedStudent.Name = txtName.Text;
                        SelectedStudent.Age = int.Parse(txtAge.Text);
                        SelectedStudent.Grade = txtGrade.Text;
                        SelectedStudent.Sex = txtSex.Text;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                students.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE Name LIKE @Name", conn);
                    command.Parameters.AddWithValue("@Name", "%" + txtName.Text + "%");

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student = new Student()
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Age = (int)reader["Age"],
                            Grade = reader["Grade"].ToString(),
                            Sex = reader["Sex"].ToString()
                        };

                        students.Add(student);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }
    



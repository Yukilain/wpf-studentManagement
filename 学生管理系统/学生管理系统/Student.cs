using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理系统
{
   
        public class Student : INotifyPropertyChanged
        {
            private int id;
            private string name;
            private int age;
            private string grade;
            private string sex;

            public int Id
            {
                get { return id; }
                set { id = value; OnPropertyChanged("Id"); }
            }

            public string Name
            {
                get { return name; }
                set { name = value; OnPropertyChanged("Name"); }
            }

            public int Age
            {
                get { return age; }
                set { age = value; OnPropertyChanged("Age"); }
            }

            public string Grade
            {
                get { return grade; }
                set { grade = value; OnPropertyChanged("Grade"); }
            }
            public string Sex
            {
                get { return sex; }
                set { sex = value; OnPropertyChanged("Sex"); }
            }

        public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


// select from students where Name ="张三"
//insert (id,name,sex,grade) into students values ( , , ,) 
// delete from students where Name = "张三"
// update 
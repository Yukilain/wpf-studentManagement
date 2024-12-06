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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 学生管理系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string account = userName.Text.Trim();
            string password = passwordbox.Password;

            if (account == "" || password == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }
            if (account == "admin" && password == "admin")
            {
                index Index1 = new index();
                Index1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入正确的用户名和密码！");
                return;
            }
        }

        private void userName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

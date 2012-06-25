using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSandBox
{
    /// <summary>
    /// UserControl1.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static readonly DependencyProperty IsButtonMouseOverProperty = DependencyProperty.Register("IsButtonMouseOver",
    typeof(bool), typeof(UserControl1), new PropertyMetadata(false));

        public bool IsButtonMouseOver
        {
            get { return (bool)this.GetValue(IsButtonMouseOverProperty); }
            set { this.SetValue(IsButtonMouseOverProperty, value); }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            this.IsButtonMouseOver = this.button1.IsMouseOver;

        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            this.IsButtonMouseOver = this.button1.IsMouseOver;
        }
    }
}

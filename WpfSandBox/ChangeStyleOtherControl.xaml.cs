using System.Windows;
using System.Windows.Input;

namespace WpfSandBox
{
    /// <summary>
    /// ChangeStyleOtherControl.xaml の相互作用ロジック
    /// </summary>
    public partial class ChangeStyleOtherControl
    {
        public static readonly DependencyProperty IsButtonMouseOverProperty = DependencyProperty.Register("IsButtonMouseOver",
    typeof(bool), typeof(ChangeStyleOtherControl), new PropertyMetadata(false));

        public bool IsButtonMouseOver
        {
            get { return (bool)GetValue(IsButtonMouseOverProperty); }
            set { SetValue(IsButtonMouseOverProperty, value); }
        }

        public ChangeStyleOtherControl()
        {
            InitializeComponent();
        }

        private void Button1MouseEnter(object sender, MouseEventArgs e)
        {
            IsButtonMouseOver = button1.IsMouseOver;
        }

        private void Button1MouseLeave(object sender, MouseEventArgs e)
        {
            IsButtonMouseOver = button1.IsMouseOver;
        }
    }
}

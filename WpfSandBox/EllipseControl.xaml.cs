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
    /// EllipseControl.xaml の相互作用ロジック
    /// </summary>
    public partial class EllipseControl : UserControl
    {
        /// <summary>
        /// The aspect property.
        /// </summary>
        public static DependencyProperty AspectProperty = DependencyProperty.Register(
            "Aspect", typeof(double), typeof(EllipseControl), new PropertyMetadata(2.0));

        public EllipseControl()
        {
            InitializeComponent();
            this.SizeChanged += (sender, args) =>
                { double aspect =  (this.outerGrid.ActualWidth / this.outerGrid.ActualHeight) /2;
                    this.SetValue(AspectProperty, aspect);};
        }

        public double Aspect
        {
            get
            {
                return (double)this.GetValue(AspectProperty);
            }
        }
    }
}

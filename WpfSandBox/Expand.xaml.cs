// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Expand.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Expand.xaml の相互作用ロジック
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WpfSandBox
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Shapes;

    /// <summary>
    /// Expand.xaml の相互作用ロジック
    /// </summary>
    public partial class Expand : UserControl
    {
        private Point rightTop;
        /// <summary>
        /// Initializes a new instance of the <see cref="Expand"/> class.
        /// </summary>
        public Expand()
        {
            InitializeComponent();
            this.Loaded += (d, e) =>
                {
                    Line l1 = new Line();
                    l1.Stroke = new SolidColorBrush(Colors.Blue);
                    l1.X1 = 0;
                    l1.Y1 = 0;
                    l1.X2 = rightTop.X;
                    l1.Y2 = rightTop.Y;
                    this.outerGrid.Children.Add(l1);
                };
            this.SizeChanged += (sender, args) =>
                { 
                    rightTop.X = args.NewSize.Width - 20;
                    rightTop.Y = 20;
                    this.innerLine1.X1 = args.NewSize.Width - 20;
                    this.outerGrid.UpdateLayout();
                };
        }
    }
}

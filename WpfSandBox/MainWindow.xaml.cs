using System.Windows;

namespace WpfSandBox
{
	using NLog;
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Resources["res1"] = Properties.Settings.Default.TextColor;
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			Logger logger = LogManager.GetLogger("");
			logger.Info("tesuto");
		}
	}
}

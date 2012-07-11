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
	/// アイコンが入れれるボタン
	/// </summary>
	public class IconAttachButton : Button
	{
		private IconAttach _iconAttach = new IconAttach();

		static IconAttachButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(IconAttachButton), new FrameworkPropertyMetadata(typeof(IconAttachButton)));
		}

		public IconAttachButton()
		{
			this.DataContext = this._iconAttach;
		}

		public ImageSource OnIcon
		{
			get
			{
				return _iconAttach.OnIcon;
			}

			set
			{
				_iconAttach.OnIcon = value;
			}
		}

		public ImageSource OffIcon
		{
			get
			{
				return _iconAttach.OffIcon;
			}

			set
			{
				_iconAttach.OffIcon = value;
			}
		}

		protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == Button.IsPressedProperty)
			{
				_iconAttach.IsOn = (bool)e.NewValue;
			}
		}
	}
}

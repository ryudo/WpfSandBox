namespace WpfSandBox
{
	using System.ComponentModel;
	using System.Windows.Media;

	class IconAttach : INotifyPropertyChanged
	{
		private ImageSource _on;
		private ImageSource _off;
		private ImageSource _icon;

		private bool _isOn;


		public ImageSource OnIcon
		{
			get
			{
				return _off;
			}
			set
			{
				if (value != _on)
				{
					_on = value;
					this.RaisePropertyChanged("OnIcon");
				}
			}
		}

		public ImageSource OffIcon
		{
			get
			{
				return _on;
			}
			set
			{
				if (value != _off)
				{
					_off = value;
					this.RaisePropertyChanged("OffIcon");
				}
			}
		}

		public ImageSource Icon
		{
			get
			{
				if(this.IsOn)
				{
					return _on;
				}
				else
				{
					return _off;
				}
			}
			set
			{
				_icon = value;
				this.RaisePropertyChanged("Icon");
			}
		}

		public bool IsOn
		{
			get
			{
				return _isOn;
			}
			set
			{
				if (value != _isOn)
				{
					_isOn = value;
					if (_isOn)
					{
						this.Icon = this.OnIcon;
					}
					else
					{
						this.Icon = this.OffIcon;
					}
					this.RaisePropertyChanged("IsOn");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			var d = PropertyChanged;
			if (d != null)
				d(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

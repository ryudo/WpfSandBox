﻿using System;
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
	/// OuterPathControl.xaml の相互作用ロジック
	/// </summary>
	public partial class OuterPathControl : UserControl
	{
		public OuterPathControl()
		{
			InitializeComponent();
			this.Loaded += (d, e) => {
				Pen pen = new Pen(null, 40);
				PathGeometry pathgeo = inner.Data.GetWidenedPathGeometry(pen);
				outer.Data = pathgeo;
			};
		}
	}
}

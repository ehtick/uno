﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Tests.Windows_UI_Xaml_Data.xBindTests
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Given_xBind_DataTemplate_Control : Page
	{
		public Given_xBind_DataTemplate_Control()
		{
			this.InitializeComponent();
			root.Content = new MyDataTemplateClass();
		}

	}

	public class MyDataTemplateClass : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _myproperty = "Initial";
		private int _myIntProperty = -3;

		public string MyProperty
		{
			get { return _myproperty; }
			set
			{
				_myproperty = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
			}
		}

		public int MyIntProperty
		{
			get { return _myIntProperty; }
			set
			{
				_myIntProperty = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyIntProperty)));
			}
		}
	}

}

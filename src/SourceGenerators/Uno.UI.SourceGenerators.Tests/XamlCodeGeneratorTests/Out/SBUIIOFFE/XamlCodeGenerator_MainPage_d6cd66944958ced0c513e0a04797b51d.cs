﻿// <autogenerated />
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers;
using Uno.UI.Helpers.Xaml;
using MyProject;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#else
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace TestRepro
{
	partial class MainPage : global::Microsoft.UI.Xaml.Controls.Page
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		private global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
		private void InitializeComponent()
		{
			NameScope.SetNameScope(this, __nameScope);
			var __that = this;
			base.IsParsing = true;
			// Source 0\MainPage.xaml (Line 1:2)
			base.Content = 
			new global::Microsoft.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				// Source 0\MainPage.xaml (Line 8:3)
				Children = 
				{
					new global::Microsoft.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						Text = "Hello, world!",
						Margin = new global::Microsoft.UI.Xaml.Thickness(20),
						FontSize = 30d,
						// Source 0\MainPage.xaml (Line 9:4)
					}
					.GenericApply(__that, __nameScope, (ApplyMethod_0					))
					,
				}
			}
			.GenericApply(__that, __nameScope, (ApplyMethod_1			))
			;
			
			this
			.GenericApply(__that, __nameScope, (ApplyMethod_2			))
			.GenericApply(__that, __nameScope, (ApplyMethod_3			))
			;
			OnInitializeCompleted();

		}
		partial void OnInitializeCompleted();
							private void ApplyMethod_0(global::Microsoft.UI.Xaml.Controls.TextBlock __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
					{
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 9, 4);
						__p1.CreationComplete();
					}

					private void ApplyMethod_1(global::Microsoft.UI.Xaml.Controls.Grid __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
			{
				global::Uno.UI.Toolkit.VisibleBoundsPadding.SetPaddingMask(__p1, global::Uno.UI.Toolkit.VisibleBoundsPadding.PaddingMask.Top);
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 8, 3);
				__p1.CreationComplete();
			}

					private void ApplyMethod_2(global::Microsoft.UI.Xaml.Controls.Page __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
			{
				// Source 0\MainPage.xaml (Line 1:2)
				
				// WARNING Property __p1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}

					private void ApplyMethod_3(global::Microsoft.UI.Xaml.Controls.Page __p1, MainPage __that, global::Microsoft.UI.Xaml.NameScope __nameScope)
			{
				// Class TestRepro.MainPage
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(__p1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d, "file:///C:/Project/0/MainPage.xaml", 1, 2);
				__p1.CreationComplete();
			}

		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
			void NotifyXLoad(string name);
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::TestRepro.MainPage Owner { get => (global::TestRepro.MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::TestRepro.MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(global::TestRepro.MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.NotifyXLoad(string name)
			{
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IMainPage_Bindings.UpdateResources()
			{
				var owner = Owner;
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}
	}
}

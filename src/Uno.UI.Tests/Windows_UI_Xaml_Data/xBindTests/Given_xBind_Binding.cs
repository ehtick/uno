﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.UI.Tests.Windows_UI_Xaml_Data.xBindTests
{
	[TestClass]
	public class Given_xBind_Binding
	{
		[TestMethod]
		public void When_Initial_Value()
		{
			var SUT = new Given_xBind_Binding_Control();

			Assert.IsNull(SUT._StringField.Text);

			SUT.ForceLoaded();

			Assert.AreEqual("initial", SUT._StringField.Text);

			SUT.stringField = "updated";

			SUT.DoUpdate();

			Assert.AreEqual("updated", SUT._StringField.Text);
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uno.UI.RuntimeTests.Tests.Windows_System
{
	[TestClass]
	public class Given_DispatcherQueue
	{
		[TestMethod]
		[RunsOnUIThread]
		public void When_GetForCurrentThreadFromDispatcher()
		{
			Assert.IsNotNull(DispatcherQueue.GetForCurrentThread());
		}

#if !__WASM__ // Wasm does not have bg threads yet ...
		[TestMethod]
		[PlatformCondition(ConditionMode.Exclude, RuntimeTestPlatforms.SkiaWasm)]
		public void When_GetForCurrentThreadFromBackgroundThread()
		{
			Assert.IsNull(DispatcherQueue.GetForCurrentThread());
		}
#endif
	}
}

﻿using System;
using System.Threading;
using Uno.UI.Dispatching;


#if HAS_UNO_WINUI && IS_UNO_UI_DISPATCHING_PROJECT
namespace Microsoft.UI.Dispatching;
#else
namespace Windows.System;
#endif

partial class DispatcherQueueTimer
{
	private readonly TimeSpan _minInterval = TimeSpan.FromMilliseconds(1);

	private Timer _timer;

	private void StartNative(TimeSpan interval)
	{
		_timer ??= new Timer(_ => DispatchRaiseTick());
		_timer.Change(ClampInterval(interval), Timeout.InfiniteTimeSpan);
	}

	private void StartNative(TimeSpan dueTime, TimeSpan interval) => StartNative(dueTime);

	private void DispatchRaiseTick()
	{
#if __WASM__
		if (!CoreDispatcher.IsThreadingSupported)
		{
			RaiseTick();
			return;
		}
#endif
		_ = CoreDispatcher.Main.RunAsync(Uno.UI.Dispatching.CoreDispatcherPriority.Normal, () => RaiseTick());
	}

	partial void OnTickFinished(bool continueTicking)
	{
		if (IsRunning && IsRepeating && continueTicking)
		{
			_timer.Change(ClampInterval(Interval), Timeout.InfiniteTimeSpan);
		}
	}

	private void StopNative()
	{
		_timer?.Dispose();
		_timer = null;
	}

	/// <summary>
	/// Timer class does not support zero interval.
	/// This clamps it to at least single tick.
	/// </summary>
	/// <param name="interval">Interval.</param>
	/// <returns>Clamped interval.</returns>
	private TimeSpan ClampInterval(TimeSpan interval) =>
		interval <= _minInterval ?
			_minInterval :
			interval;
}

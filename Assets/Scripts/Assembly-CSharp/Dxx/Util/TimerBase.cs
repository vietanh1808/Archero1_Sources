using System;
using System.Runtime.CompilerServices;
using System.Timers;
using Dxx.Collections;
using UnityEngine;

namespace Dxx.Util
{
	public abstract class TimerBase<T> : MonoBehaviour where T : TimerBase<T>
	{
		private struct TimerData
		{
			public long id;

			public string key;

			public float interval;

			public Action<float> onTimer1;

			public Action onTimer2;

			public Action onCanceled;

			public int times;
		}

		[CompilerGenerated]
		private Action m_onTimerChanged;

		private static System.Timers.Timer mTimer;

		private static float mRealTime;

		private static T s_instance;

		private long mIdGen;

		private KeyedPriorityQueue<long, TimerData, double> mQueue;

		protected virtual bool InGameUpdate => false;

		public event Action onTimerChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static float GetRealTime()
		{
			return 0f;
		}

		private static void timer_Elapsed(object sender, ElapsedEventArgs e)
		{
		}

		public static void Register(string key, float delay, float interval, Action onTimer)
		{
		}

		public static void Register(string key, float delay, float interval, Action<float> onTimer)
		{
		}

		public static void Register(string key, float delay, float interval, Action onTimer, Action onCanceled)
		{
		}

		public static void Register(string key, float delay, float interval, Action<float> onTimer, Action onCanceled)
		{
		}

		public static void Register(string key, float delay, float interval, Action onTimer, int times)
		{
		}

		public static void Register(string key, float delay, float interval, Action<float> onTimer, int times)
		{
		}

		public static void Register(string key, float delay, float interval, Action onTimer, Action onCanceled, int times)
		{
		}

		public static void Register(string key, float delay, float interval, Action<float> onTimer, Action onCanceled, int times)
		{
		}

		public static void Register(string key, float timeout, Action onTimer)
		{
		}

		public static void Register(string key, float timeout, Action<float> onTimer)
		{
		}

		public static void Register(string key, float timeout, Action onTimer, Action onCanceled)
		{
		}

		public static void Register(string key, float timeout, Action<float> onTimer, Action onCanceled)
		{
		}

		public static void Register(string key, float timeout, Action onTimer, int times)
		{
		}

		public static void Register(string key, float timeout, Action<float> onTimer, int times)
		{
		}

		public static void Register(string key, float timeout, Action onTimer, Action onCanceled, int times)
		{
		}

		public static void Register(string key, float timeout, Action<float> onTimer, Action onCanceled, int times)
		{
		}

		public static ulong Register(float delay, float interval, Action onTimer)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action<float> onTimer)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action onTimer, Action onCanceled)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action<float> onTimer, Action onCanceled)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action onTimer, int times)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action<float> onTimer, int times)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action onTimer, Action onCanceled, int times)
		{
			return 0uL;
		}

		public static ulong Register(float delay, float interval, Action<float> onTimer, Action onCanceled, int times)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action onTimer)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action<float> onTimer)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action onTimer, Action onCanceled)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action<float> onTimer, Action onCanceled)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action onTimer, int times)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action<float> onTimer, int times)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action onTimer, Action onCanceled, int times)
		{
			return 0uL;
		}

		public static ulong Register(float timeout, Action<float> onTimer, Action onCanceled, int times)
		{
			return 0uL;
		}

		public static bool Unregister(string key)
		{
			return false;
		}

		public static void Unregister()
		{
		}

		public static bool Unregister(ulong id)
		{
			return false;
		}

		private static T GetInstance()
		{
			return null;
		}

		protected abstract void OnChanged();

		protected abstract void OnUpdate();

		protected int GetTimers()
		{
			return 0;
		}

		private ulong RegisterInternal(string key, float delay, float interval, Action<float> onTimer1, Action onTimer2, Action onCanceled, int times)
		{
			return 0uL;
		}

		private bool UnregisterInternal(string key)
		{
			return false;
		}

		private bool UnregisterInternal(long id)
		{
			return false;
		}

		public float GetCurrentTime()
		{
			return 0f;
		}

		protected void Update()
		{
		}

		public void OnRemove()
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dxx.Util
{
	public class Updater : MonoBehaviour
	{
		[CompilerGenerated]
		private Action<float> m_onUpdate;

		[CompilerGenerated]
		private Action<float> m_onUpdateIgnoreTime;

		[CompilerGenerated]
		private Action m_onLateUpdate;

		[CompilerGenerated]
		private Action m_onFixedUpdate;

		[CompilerGenerated]
		private Action<float> m_onUpdateUI;

		[CompilerGenerated]
		private Action<float> m_onUpdateUIIgnoreTime;

		private static bool bCreate;

		private static float _AliveTime;

		private static float _deltatime;

		private static float _unscaleAliveTime;

		private static float _unscaledeltatime;

		public int count;

		private static Updater updater;

		public static float AliveTime => 0f;

		public static float delta => 0f;

		public static float deltaIgnoreTime => 0f;

		public static float unscaleAliveTime => 0f;

		public event Action<float> onUpdate
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

		public event Action<float> onUpdateIgnoreTime
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

		public event Action onLateUpdate
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

		public event Action onFixedUpdate
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

		public event Action<float> onUpdateUI
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

		public event Action<float> onUpdateUIIgnoreTime
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

		private void Update()
		{
		}

		public void Init()
		{
		}

		public void OnRelease()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		public static Updater Get(GameObject go)
		{
			return null;
		}

		public static Updater GetUpdater()
		{
			return null;
		}

		public static void UpdaterDeinit()
		{
		}

		public static void AddUpdate(string name, Action<float> func, bool IgnoreTimeScale = false)
		{
		}

		public static void RemoveUpdate(string name, Action<float> func)
		{
		}

		public static void AddLateUpdate(Action func)
		{
		}

		public static void RemoveLateUpdate(Action func)
		{
		}

		public static void AddFixedUpdate(Action func)
		{
		}

		public static void RemoveFixedUpdate(Action func)
		{
		}

		public static void AddUpdateUI(Action<float> func, bool IgnoreTimeScale = false)
		{
		}

		public static void RemoveUpdateUI(Action<float> func)
		{
		}
	}
}

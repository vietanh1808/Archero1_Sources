using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	internal class HIDManager : IHIDManager
	{
		[CompilerGenerated]
		private sealed class _003CCheckRefreshTokenValid_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HIDManager _003C_003E4__this;

			public HIDDelegate callBack;

			private UnityWebRequest _003Crequest_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheckRefreshTokenValid_003Ed__28(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCheckTokenValid_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HIDManager _003C_003E4__this;

			public HIDDelegate callBack;

			private HabbyIdLoginData _003ClocalData_003E5__2;

			private UnityWebRequest _003Crequest_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheckTokenValid_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static HIDManager instance;

		internal MonoBehaviour MonoDriver;

		internal IHIDDriver IhidDriver;

		private FiniteStateMachine fsm;

		public const string FileName = "_login_HID.dat";

		private HabbyIdLoginData _habbyIdLoginData;

		private int refFailCount;

		public static HIDManager Instance => null;

		public bool IsSilentRefreshMode { get; set; }

		private HIDManager()
		{
		}

		~HIDManager()
		{
		}

		private void HandleLogout(object obj)
		{
		}

		private void HandleModifyInfo(V2C_ModifyInfo obj)
		{
		}

		public void OnEnterGame<T>(T tMono) where T : MonoBehaviour, IHIDDriver
		{
		}

		public void Update()
		{
		}

		public void Dispose()
		{
		}

		public void OnClickHIDLogin()
		{
		}

		public void OnClickHIDLoginSilent()
		{
		}

		public void Log(string message)
		{
		}

		public void LogError(string message)
		{
		}

		internal void SaveHabbyIdLoginData(HabbyIdLoginData data)
		{
		}

		public HabbyIdLoginData GetHabbyIdLoginData()
		{
			return null;
		}

		public bool IsLogin()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CCheckTokenValid_003Ed__26))]
		public IEnumerator CheckTokenValid(HIDDelegate callBack)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckRefreshTokenValid_003Ed__28))]
		public IEnumerator CheckRefreshTokenValid(HIDDelegate callBack)
		{
			return null;
		}
	}
}

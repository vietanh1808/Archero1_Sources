using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	internal class LogoutState : StateBase
	{
		[CompilerGenerated]
		private sealed class _003CLogout_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LogoutState _003C_003E4__this;

			public string accessToken;

			public Action<bool> cBack;

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
			public _003CLogout_003Ed__3(int _003C_003E1__state)
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

		public LogoutState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		public override void Enter()
		{
		}

		private void OnLogoutSuccess(bool result)
		{
		}

		[IteratorStateMachine(typeof(_003CLogout_003Ed__3))]
		private IEnumerator Logout(string accessToken, Action<bool> cBack)
		{
			return null;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	internal class RegisterHIDState : StateBase
	{
		[CompilerGenerated]
		private sealed class _003CCheckEmailCanBind_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RegisterHIDState _003C_003E4__this;

			public string email;

			public Action<bool, bool> callback;

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
			public _003CCheckEmailCanBind_003Ed__4(int _003C_003E1__state)
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

		public RegisterHIDState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		~RegisterHIDState()
		{
		}

		private void CheckEmailCanBindEvent(V2C_CheckEmailCanBindEvent obj)
		{
		}

		public override void Enter()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckEmailCanBind_003Ed__4))]
		private IEnumerator CheckEmailCanBind(string email, Action<bool, bool> callback)
		{
			return null;
		}
	}
}

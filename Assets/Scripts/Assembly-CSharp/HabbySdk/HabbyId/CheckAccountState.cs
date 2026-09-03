using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	internal class CheckAccountState : StateBase
	{
		[CompilerGenerated]
		private sealed class _003CCheckAccountBindHID_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CheckAccountState _003C_003E4__this;

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
			public _003CCheckAccountBindHID_003Ed__2(int _003C_003E1__state)
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

		internal CheckAccountState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		public override void Enter()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckAccountBindHID_003Ed__2))]
		private IEnumerator CheckAccountBindHID()
		{
			return null;
		}

		private void OnHIDBind()
		{
		}

		private void OnHIDUnBind()
		{
		}
	}
}

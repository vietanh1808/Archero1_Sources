using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	internal class ModifyInfoState : StateBase
	{
		[CompilerGenerated]
		private sealed class _003CModifyUserInfo_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ModifyInfoState _003C_003E4__this;

			public int? gameUpdatesAndNews;

			public int? eventsAndBonus;

			public int? communityInteraction;

			public int? shopSpecialOffer;

			public int? newsForHabby;

			public string accessToken;

			public Action callBack;

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
			public _003CModifyUserInfo_003Ed__3(int _003C_003E1__state)
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

		public ModifyInfoState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		public void ModifyInfo(string accessToken, int? gameUpdatesAndNews, int? eventsAndBonus, int? communityInteraction, int? shopSpecialOffer, int? newsForHabby, Action callBack)
		{
		}

		public override void Enter()
		{
		}

		[IteratorStateMachine(typeof(_003CModifyUserInfo_003Ed__3))]
		private IEnumerator ModifyUserInfo(string accessToken, int? gameUpdatesAndNews, int? eventsAndBonus, int? communityInteraction, int? shopSpecialOffer, int? newsForHabby, Action callBack)
		{
			return null;
		}
	}
}

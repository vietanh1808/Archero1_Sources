using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

namespace Activity
{
	public class CumulativeConsumptionPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CQuit_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CumulativeConsumptionPanel _003C_003E4__this;

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
			public _003CQuit_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003CTick_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CumulativeConsumptionPanel _003C_003E4__this;

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
			public _003CTick_003Ed__14(int _003C_003E1__state)
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

		[SerializeField]
		private CumulativeInfinity infinity;

		[SerializeField]
		private GameObject propTemplate;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtTitleSr;

		private LocalUnityObjctPool pool;

		private Coroutine quitCor;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Quit;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_GetCurEvent;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Init(IActivityUI activityUI)
		{
		}

		[IteratorStateMachine(typeof(_003CQuit_003Ed__8))]
		private IEnumerator Quit()
		{
			return null;
		}

		public override void Open()
		{
		}

		private ActivityMgr.Event GetCurEvent()
		{
			return ActivityMgr.Event.None_CheckIn;
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__14))]
		private IEnumerator Tick()
		{
			return null;
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}

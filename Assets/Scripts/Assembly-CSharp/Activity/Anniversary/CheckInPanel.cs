using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Anniversary
{
	public class CheckInPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CheckInPanel _003C_003E4__this;

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
			public _003CTick_003Ed__11(int _003C_003E1__state)
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
		private DxxText txtCountdownTab;

		[SerializeField]
		private CheckInItem itemTemplate;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private RectTransform rtItemsRoot;

		[SerializeField]
		private ScrollRect sr;

		private LocalUnityObjctPool pool;

		private Coroutine coroutine;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Init(IActivityUI ctrl)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public override void Refresh()
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__11))]
		private IEnumerator Tick()
		{
			return null;
		}

		public override void OnHandleNotification(INotification notification)
		{
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

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}

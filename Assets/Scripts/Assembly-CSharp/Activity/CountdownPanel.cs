using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

namespace Activity
{
	public class CountdownPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CountdownPanel _003C_003E4__this;

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
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtCountdown;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtBtnClose;

		[SerializeField]
		private ButtonCtrl btnClose;

		private long openTime;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Escape;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override bool Escape()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__11))]
		private IEnumerator Tick()
		{
			return null;
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

		private bool _003C_003ExLuaBaseProxy_Escape()
		{
			return false;
		}
	}
}

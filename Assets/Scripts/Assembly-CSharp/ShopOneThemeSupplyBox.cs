using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;
using XLua;

public class ShopOneThemeSupplyBox : ShopOneBase
{
	[CompilerGenerated]
	private sealed class _003CUpdateTime_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopOneThemeSupplyBox _003C_003E4__this;

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
		public _003CUpdateTime_003Ed__12(int _003C_003E1__state)
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

	public Text Title;

	public ShopItemThemeSupplyBox[] Items;

	public CountDownCtrl TimeShow;

	public CountDownCtrl TimeShow2;

	public CountDownCtrl TimeShow3;

	public CountDownCtrl TimeRest;

	private bool IfNextDay;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	public override void UpdateUI()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTime_003Ed__12))]
	private IEnumerator UpdateTime()
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}
}

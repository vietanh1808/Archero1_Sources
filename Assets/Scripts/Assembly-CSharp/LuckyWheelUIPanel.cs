using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class LuckyWheelUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LuckyWheelUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__35(int _003C_003E1__state)
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
	private LuckyWheelReward luckyWheelReward;

	[SerializeField]
	private LuckyWheelTask luckyWheelTask;

	[SerializeField]
	private LuckyWheelExtraReward luckyWheelExtraReward;

	[SerializeField]
	private ButtonCtrl drawFree;

	[SerializeField]
	private ButtonCtrl drawOne;

	[SerializeField]
	private ButtonCtrl drawTen;

	[SerializeField]
	private DxxText drawFreeName;

	[SerializeField]
	private DxxText drawOneName;

	[SerializeField]
	private DxxText drawTenName;

	[SerializeField]
	private DxxText drawFreeLeftCount;

	[SerializeField]
	private DxxText drawOnePrice;

	[SerializeField]
	private DxxText drawTenPrice;

	[SerializeField]
	private DxxText drawLeftCount;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_get_LuckyWheelData;

	private static DelegateBridge __Hotfix0_get_LuckyWheelExtraRewardData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_ClickFree;

	private static DelegateBridge __Hotfix0_ClickOne;

	private static DelegateBridge __Hotfix0_ClickTen;

	private static DelegateBridge __Hotfix0_RequestWheelReward;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_CloseWindow;

	private static DelegateBridge __Hotfix0_ClickOneDisable;

	private static DelegateBridge __Hotfix0_ClickTenDisable;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_GetDrawGemCost;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	private LuckyWheelData LuckyWheelData => null;

	private LuckyWheelExtraRewardData LuckyWheelExtraRewardData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__35))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void ClickFree()
	{
	}

	private void ClickOne()
	{
	}

	private void ClickTen()
	{
	}

	private void RequestWheelReward(int drawCount, bool isFree)
	{
	}

	private void RequestReward(int drawCount, bool isFree)
	{
	}

	private void PlayAni(int drawID, Action done)
	{
	}

	private void CloseWindow()
	{
	}

	private void ClickOneDisable()
	{
	}

	private void ClickTenDisable()
	{
	}

	private void ClickInfo()
	{
	}

	private void RefreshRed()
	{
	}

	private int GetDrawGemCost(int drawCount)
	{
		return 0;
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}

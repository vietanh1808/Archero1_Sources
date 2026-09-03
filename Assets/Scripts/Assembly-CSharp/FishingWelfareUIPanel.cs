using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class FishingWelfareUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingWelfareUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__33(int _003C_003E1__state)
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
	private DxxText title;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private FishingGiftUIPanel giftPanel;

	[SerializeField]
	private FishingTaskUIPanel taskPanel;

	[SerializeField]
	private DxxText giftSelectName;

	[SerializeField]
	private DxxText giftUnselectName;

	[SerializeField]
	private DxxText taskSelectName;

	[SerializeField]
	private DxxText taskUnselectName;

	[SerializeField]
	private RedNodeCtrl giftRed;

	[SerializeField]
	private RedNodeCtrl taskRed;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private OfficialStoreBannerCtrl _goOfficialStoreBanner;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private int curSelectIndex;

	private IUILifeCycle curPanel;

	private bool m_bTaskPanelInited;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_FishingData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_SwitchPanel;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private FishingData FishingData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void ClickTab(int index)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshRed()
	{
	}

	private IUILifeCycle SwitchPanel()
	{
		return null;
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__33))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void Esc()
	{
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

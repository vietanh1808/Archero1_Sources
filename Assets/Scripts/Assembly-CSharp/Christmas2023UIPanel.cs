using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class Christmas2023UIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Christmas2023UIPanel _003C_003E4__this;

		private Exchange2023Data _003CexcData_003E5__2;

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
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl info;

	[Header("模块面板")]
	[SerializeField]
	private Vault2023UIPanel vault2023;

	[SerializeField]
	private Challenge2023UIPanel challenge2023;

	[SerializeField]
	private GameObject mask;

	private IUILifeCycle curPanle;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private int curSelectIndex;

	public ButtonCtrl Button_Task;

	public DxxText Text_Task;

	public GameObject RedPoint_Task;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Christmas2023Data;

	private static DelegateBridge __Hotfix0_get_Vault2023Data;

	private static DelegateBridge __Hotfix0_get_Challenge2023Data;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_SwitchPanel;

	private static DelegateBridge __Hotfix0_LeftTime;

	private static DelegateBridge __Hotfix0_onButtonTask;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Christmas2023Data Christmas2023Data => null;

	private Vault2023Data Vault2023Data => null;

	private Challenge2023Data Challenge2023Data => null;

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

	public void ClickTab(int index)
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

	private void RefreshRed()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__33))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void ClickInfo()
	{
	}

	private void Esc()
	{
	}

	private IUILifeCycle SwitchPanel()
	{
		return null;
	}

	private long LeftTime()
	{
		return 0L;
	}

	private void onButtonTask()
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

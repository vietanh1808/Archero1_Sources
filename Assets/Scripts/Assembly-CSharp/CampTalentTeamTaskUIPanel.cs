using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentTeamTaskUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampTalentTeamTaskUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__23(int _003C_003E1__state)
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
	private Transform parent;

	[SerializeField]
	private CampTalentTeamTaskProgressItem progressItem;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ScrollRect scrollRect;

	private LocalUnityObjctPool taskPool;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_get_CampManager;

	private static DelegateBridge __Hotfix0_get_CampTalentManager;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamTaskData;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamTaskProgressData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampManager CampManager => null;

	private CampTalentManager CampTalentManager => null;

	private CampTalentTeamTaskData CampTalentTeamTaskData => null;

	private CampTalentTeamTaskProgressData CampTalentTeamTaskProgressData => null;

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

	public void InitObjectPool()
	{
	}

	public void RefreshItem()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__23))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public void RefreshTime()
	{
	}

	public override void OnHandleNotification(INotification notification)
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

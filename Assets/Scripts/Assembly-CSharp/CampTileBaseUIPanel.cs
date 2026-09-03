using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public abstract class CampTileBaseUIPanel<T1, T2> : MediatorCtrlBase where T1 : CampTileBaseData<T2> where T2 : CampTileBaseConfigData
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampTileBaseUIPanel<T1, T2> _003C_003E4__this;

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
		public _003CCountDown_003Ed__22(int _003C_003E1__state)
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

	protected T1 data;

	[SerializeField]
	protected DxxText countDown;

	[SerializeField]
	protected GameObject countDownObj;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_ClickBtnExtra;

	private static DelegateBridge __Hotfix0_IsBtnEnableExtra;

	private static DelegateBridge __Hotfix0_ClickBtnDisableExtra;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_RefreshTimeShow;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected abstract WindowID CurWindowID { get; }

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

	protected void SetData(T1 data)
	{
	}

	protected abstract void Refresh();

	protected abstract void PlayAni(List<CampTileArrowDamageData> damageData, CRespCampBlock response, int oldLevel, CampTileOccupyAttackType attackType, int returnIronArrow, int returnGoldArrow, CampID recordOccupyCamp, int attackMonsterCampID);

	protected virtual bool ClickBtnExtra()
	{
		return false;
	}

	protected virtual bool IsBtnEnableExtra()
	{
		return false;
	}

	protected virtual bool ClickBtnDisableExtra()
	{
		return false;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void Esc()
	{
	}

	protected virtual void RefreshTimeShow()
	{
	}

	protected virtual void RefreshCountDown()
	{
	}

	protected virtual bool RefreshTime()
	{
		return false;
	}

	[IteratorStateMachine(typeof(CampTileBaseUIPanel<, >._003CCountDown_003Ed__22))]
	private IEnumerator CountDown()
	{
		return null;
	}
}

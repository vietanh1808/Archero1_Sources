using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingGhostFleetUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingGhostFleetUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__48(int _003C_003E1__state)
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
	private SailingGhostFleetShip ship;

	[SerializeField]
	private SailingGhostFleetRanking ranking;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText titleName;

	[SerializeField]
	private DxxText tipText;

	[SerializeField]
	private DxxText haveDiamondCount;

	[SerializeField]
	private DxxText needDiamondCount;

	[SerializeField]
	private DxxText freeRefreshName;

	[SerializeField]
	private GameObject refreshFreeStatus;

	[SerializeField]
	private GameObject refreshCostStatus;

	[SerializeField]
	private DxxText staminaCount;

	[SerializeField]
	private ButtonCtrl playGameBtn;

	[SerializeField]
	private DxxText playGameBtnName;

	[SerializeField]
	private ButtonCtrl refreshBtn;

	[SerializeField]
	private DxxText refreshBtnName;

	[SerializeField]
	private SailingGhostFleetTip tip;

	[SerializeField]
	private DxxText challengeLimit;

	[SerializeField]
	private DxxText countDown;

	private int selectIndex;

	private long enterUITime;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private SailingManager SailingManager => null;

	private SailingGhostFleetManager SailingGhostFleetManager => null;

	private SailingGhostFleetData SailingGhostFleetData => null;

	private SailingGhostFleetShipItemData CurSelectShipItemData => null;

	private bool HaveFreeRefreshCount => false;

	private bool HaveEnoughDiamond => false;

	private bool HaveEnoughStamina => false;

	public bool AllowPlayGame => false;

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

	private void Refresh(bool isPlayAni)
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

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__48))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void ClickInfoBtn()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickPlayGameBtn()
	{
	}

	private void ClickRefreshBtn()
	{
	}

	private void ClickRefreshBtnReal()
	{
	}

	private void Esc()
	{
	}

	private bool OnCheckGuideCondition(SailingGuideManager.GuideModule module)
	{
		return false;
	}
}

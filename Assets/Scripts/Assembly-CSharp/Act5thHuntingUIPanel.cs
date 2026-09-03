using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act5thHuntingUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__51(int _003C_003E1__state)
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
	private DxxText gitBtnName;

	[SerializeField]
	private DxxText shopBtnName;

	[SerializeField]
	private DxxText rankingBtnName;

	[SerializeField]
	private DxxText huntingTicketCount;

	[SerializeField]
	private DxxText taskBtnName;

	[SerializeField]
	private DxxText talentBtnName;

	[SerializeField]
	private DxxText sweepBtnName;

	[SerializeField]
	private DxxText sweepLockName;

	[SerializeField]
	private DxxText huntingBtnName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl giftBtn;

	[SerializeField]
	private ButtonCtrl shopBtn;

	[SerializeField]
	private ButtonCtrl rankingBtn;

	[SerializeField]
	private ButtonCtrl quickBuyBtn;

	[SerializeField]
	private ButtonCtrl taskBtn;

	[SerializeField]
	private ButtonCtrl talentBtn;

	[SerializeField]
	private ButtonCtrl sweepBtn;

	[SerializeField]
	private ButtonCtrl sweepTipBtn;

	[SerializeField]
	private ButtonCtrl huntingBtn;

	[SerializeField]
	private Act5thHuntingScene huntingScene;

	[SerializeField]
	private GameObject RedPoint_Gift;

	[SerializeField]
	private GameObject RedPoint_Shop;

	[SerializeField]
	private GameObject RedPoint_Task;

	[SerializeField]
	private RedNodeCtrl talentRed;

	[SerializeField]
	private GameObject sweepLockObj;

	[SerializeField]
	private Act5thHuntingSweep sweep;

	[SerializeField]
	private Image backgroundImg;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private bool isHuntingStarting;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingBaseData HuntingBaseData => null;

	private Act5thHuntingSceneData HuntingSceneData => null;

	private int CurSceneID => 0;

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

	private void RefreshRed()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__51))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickInfoBtn()
	{
	}

	private void ClickGiftBtn()
	{
	}

	private void ClickShopBtn()
	{
	}

	private void ClickRankingBtn()
	{
	}

	private void ClickQuickBuyBtn()
	{
	}

	private void ClickTaskBtn()
	{
	}

	private void ClickTalentBtn()
	{
	}

	private void ClickHuntingBtn()
	{
	}

	private void ClickSweepBtn()
	{
	}

	private void ClickSweepTipBtn()
	{
	}

	private void RequestHuntingStart(int costHuntingTicket)
	{
	}

	private void RequestRanking()
	{
	}

	private void Esc()
	{
	}

	private void CheckGameEndReward()
	{
	}

	private void RequestGameEnd(Action<STRespActivityHunting> success = null)
	{
	}
}

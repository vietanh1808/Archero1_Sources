using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CampKingScrambleUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampKingScrambleUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__52(int _003C_003E1__state)
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
	private DxxText sendArrowBtnName;

	[SerializeField]
	private ButtonCtrl sendArrowBtn;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private CampKingScrambleTeamAttackUIPanel teamAttack;

	[SerializeField]
	private CampKingScrambleTeamRankingUIPanel teamRanking;

	[SerializeField]
	private CampTileCurrency currency;

	[SerializeField]
	private CampKingScrambleAni kingScrambleAni;

	[SerializeField]
	private CampKingScrambleAutoSendArrowAni autoSendArrowAni;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private GameObject battleStatusObj;

	[SerializeField]
	private GameObject rewardStatusObj;

	[SerializeField]
	private HeadItem headItem;

	[SerializeField]
	private DxxText playerName;

	[SerializeField]
	private DxxText ranking;

	[SerializeField]
	private Image rankingIcon;

	[SerializeField]
	private ButtonCtrl clickHeadBtn;

	[SerializeField]
	private GameObject haveDataStatus;

	[SerializeField]
	private GameObject notDataStatus;

	[SerializeField]
	private Graphic target;

	[SerializeField]
	private SortingGroup sortingGroup;

	[SerializeField]
	private DxxText txtDesc;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private CampKingScrambleManager KingScrambleManager => null;

	private CampKingScrambleBaseData KingScrambleBaseData => null;

	private CampKingScrambleTeamAttackData KingScrambleTeamAttackData => null;

	private CampKingScrambleTeamRankingData KingScrambleTeamRankingData => null;

	private int CurCampStyle => 0;

	private bool IsShowBattleStatus => false;

	private bool IsShowRewardStatus => false;

	private CampKingScrambleTeamAttackItemData MaxScorePlayerData => null;

	private bool HaveMaxScorePlayerData => false;

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

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__52))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void ClickSendArrowBtn()
	{
	}

	private void ClickInfoBtn()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickHeadBtn()
	{
	}

	private void Esc()
	{
	}
}

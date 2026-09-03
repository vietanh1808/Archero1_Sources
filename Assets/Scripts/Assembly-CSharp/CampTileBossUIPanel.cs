using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileBossUIPanel : CampTileBaseUIPanel<CampTileBossData, CampTileBossConfigData>
{
	[CompilerGenerated]
	private sealed class _003CKingScrambleTipCountDown_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampTileBossUIPanel _003C_003E4__this;

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
		public _003CKingScrambleTipCountDown_003Ed__46(int _003C_003E1__state)
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
	private CampTileProgress progress;

	[SerializeField]
	private CampTileMonsterProgress monsterProgress;

	[SerializeField]
	private CampTileBossSpineAni bossSpineAni;

	[SerializeField]
	private CampTileContributeRank contributeRank;

	[SerializeField]
	private CampTileOccupyBtn occupyBtn;

	[SerializeField]
	private DxxText rankName;

	[SerializeField]
	private CampTileCurrency currency;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private ButtonCtrl rankBtn;

	[SerializeField]
	private CampTileAttackAni attackAni;

	[SerializeField]
	private CampTileMonsterProgressItem campLT;

	[SerializeField]
	private CampTileMonsterProgressItem campRT;

	[SerializeField]
	private CampTileMonsterProgressItem campLB;

	[SerializeField]
	private CampTileMonsterProgressItem campRB;

	[SerializeField]
	private RectTransform bossTarget;

	[SerializeField]
	private DxxText kingScrambleTip;

	[SerializeField]
	private DxxText kingScrambleBtnName;

	[SerializeField]
	private ButtonCtrl kingScrambleBtn;

	[SerializeField]
	private GameObject kingScrambleStatus;

	[SerializeField]
	private DxxText kingScrambleShowTip;

	private Coroutine coroutinekingScrambleShowTipCountDown;

	private WaitForSeconds coroutinekingScrambleShowTipCountDownWait;

	public Image LevelObj;

	public DxxText Level;

	public GameObject NameObj;

	public DxxText Name;

	private static DelegateBridge __Hotfix0_get_CurWindowID;

	private static DelegateBridge __Hotfix0_get_CurCampStyle;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshCommon;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_RefreshBossBattleState;

	private static DelegateBridge __Hotfix0_RefreshKingScrambleTipCountDown;

	private static DelegateBridge __Hotfix0_KingScrambleTipCountDown;

	private static DelegateBridge __Hotfix0_RefreshKingScrambleTip;

	private static DelegateBridge __Hotfix0_IsBtnEnableExtra;

	private static DelegateBridge __Hotfix0_ClickBtnDisableExtra;

	private static DelegateBridge __Hotfix0_GetAttackMonster;

	private static DelegateBridge __Hotfix0_ClickKingScrambleBtn;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override WindowID CurWindowID => WindowID.WindowID_Invaild;

	private int CurCampStyle => 0;

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

	protected override void Refresh()
	{
	}

	protected override void PlayAni(List<CampTileArrowDamageData> damageData, CRespCampBlock response, int oldLevel, CampTileOccupyAttackType attackType, int returnIronArrow, int returnGoldArrow, CampID recordOccupyCamp, int attackMonsterCampID)
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshCommon()
	{
	}

	public void RefreshText()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void RefreshData()
	{
	}

	protected override bool RefreshTime()
	{
		return false;
	}

	public void RefreshBossBattleState()
	{
	}

	private void RefreshKingScrambleTipCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CKingScrambleTipCountDown_003Ed__46))]
	private IEnumerator KingScrambleTipCountDown()
	{
		return null;
	}

	private void RefreshKingScrambleTip()
	{
	}

	protected override bool IsBtnEnableExtra()
	{
		return false;
	}

	protected override bool ClickBtnDisableExtra()
	{
		return false;
	}

	public CampTileMonsterProgressItem GetAttackMonster(int attackMonsterCampID)
	{
		return null;
	}

	private void ClickKingScrambleBtn()
	{
	}
}

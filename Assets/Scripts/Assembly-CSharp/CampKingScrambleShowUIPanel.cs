using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CampKingScrambleShowUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText sendArrowBtnName;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private CampKingScrambleTeamAttackUIPanel teamAttack;

	[SerializeField]
	private CampTileCurrency currency;

	[SerializeField]
	private CampKingScrambleAni kingScrambleAni;

	[SerializeField]
	private CampKingScrambleAutoSendArrowAni autoSendArrowAni;

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

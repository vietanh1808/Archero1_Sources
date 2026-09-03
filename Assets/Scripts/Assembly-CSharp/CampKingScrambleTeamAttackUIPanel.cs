using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CampKingScrambleTeamAttackUIPanel : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private CampKingScrambleTeamAttackItem camp1AttackItem;

	[SerializeField]
	private CampKingScrambleTeamAttackItem camp2AttackItem;

	[SerializeField]
	private CampKingScrambleTeamAttackItem camp3AttackItem;

	[SerializeField]
	private CampKingScrambleTeamAttackItem camp4AttackItem;

	[SerializeField]
	private DxxText rewardPreviewBtnName;

	[SerializeField]
	private ButtonCtrl rewardPreviewBtn;

	[SerializeField]
	private Image bgIcon;

	[SerializeField]
	private Image kingIcon;

	[SerializeField]
	private GameObject particle;

	private CampKingScrambleManager KingScrambleManager => null;

	private CampKingScrambleBaseData KingScrambleBaseData => null;

	private CampKingScrambleTeamAttackData KingScrambleTeamAttackData => null;

	private CampKingScrambleTeamRankingData KingScrambleTeamRankingData => null;

	private int CurCampStyle => 0;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickRewardPreviewBtn()
	{
	}
}

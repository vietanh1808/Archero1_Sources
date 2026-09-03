using UnityEngine;
using UnityEngine.UI;

public class CampKingScrambleTeamAttackItem : MonoBehaviour
{
	[SerializeField]
	private HeadItem headItem;

	[SerializeField]
	private DxxText playerName;

	[SerializeField]
	private DxxText ranking;

	[SerializeField]
	private DxxText score;

	[SerializeField]
	private Image campBg;

	[SerializeField]
	private Image rankingIcon;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private GameObject haveDataStatus;

	[SerializeField]
	private GameObject notDataStatus;

	private CampKingScrambleTeamAttackItemData itemData;

	private bool isInit;

	private CampID campID;

	private CampKingScrambleManager KingScrambleManager => null;

	private bool HaveData => false;

	private void Init()
	{
	}

	public void Refresh(CampKingScrambleTeamAttackItemData itemData, CampID campID)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshHead()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickUserInfo()
	{
	}
}

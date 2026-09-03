using GameProtocol;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityRankingItem : UITableViewCell
{
	[SerializeField]
	private DxxText ranking;

	[SerializeField]
	private DxxText normalRanking;

	[SerializeField]
	private DxxText rankingScore;

	[SerializeField]
	private DxxText playerName;

	[SerializeField]
	private HeadItem headItem;

	[SerializeField]
	private MedalItem medalItem;

	[SerializeField]
	private ButtonCtrl chestBtn;

	[SerializeField]
	private ButtonCtrl headBtn;

	[SerializeField]
	private ButtonCtrl rewardTipBtn;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private GameObject cupRankObj;

	[SerializeField]
	private GameObject normalRankObj;

	[SerializeField]
	private Image cupImg;

	[SerializeField]
	private GameObject chestObj;

	[SerializeField]
	private Image chestImg;

	private STActivityArtifactTrialRankItem data;

	private Daily_TrialRank_128 _bean;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(STActivityArtifactTrialRankItem data, bool bIsSelf = false)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshUserInfo(bool bIsSelf)
	{
	}

	private void RefreshStatus(bool bIsSelf)
	{
	}

	private void ClickChest()
	{
	}

	private void ClickUserInfo()
	{
	}

	private void ClickTip()
	{
	}

	private Color GetColor(int rankingNum)
	{
		return default;
	}
}

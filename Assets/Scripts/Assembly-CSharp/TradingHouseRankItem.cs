using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class TradingHouseRankItem : UITableViewCell
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

	private TradingHouseRankingItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private bool isSelf;

	private RectTransform _scrollViewRect;

	private bool HaveRankData => false;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(TradingHouseRankingItemData data, RectTransform scrollViewRect = null, bool isSelf = false)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshUserInfo()
	{
	}

	private void RefreshStatus()
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

	private void Update()
	{
	}
}

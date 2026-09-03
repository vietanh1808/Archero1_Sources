using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MonopolyRankingItem : UITableViewCell
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

	private MonopolyRankingItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private RectTransform _scrollViewRect;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(MonopolyRankingItemData data, RectTransform scrollRect = null)
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

	public void Close()
	{
	}
}

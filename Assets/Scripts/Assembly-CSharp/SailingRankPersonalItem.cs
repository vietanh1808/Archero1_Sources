using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingRankPersonalItem : UITableViewCell
{
	[SerializeField]
	protected DxxText ranking;

	[SerializeField]
	protected DxxText normalRanking;

	[SerializeField]
	private DxxText militaryName;

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

	[SerializeField]
	private Image leftImg;

	[SerializeField]
	private Image flowerImg;

	[SerializeField]
	private Image powerImg;

	[SerializeField]
	private DxxText powerNum;

	[SerializeField]
	private Image militaryImg;

	public bool isSelf;

	private RankType curRankType;

	protected SailingRankingItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private RectTransform _scrollViewRect;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(SailingRankingItemData data, RankType type, RectTransform scrollRect = null)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshUserInfo()
	{
	}

	protected virtual void LoadPowerImg(RankType type)
	{
	}

	private void RefreshStatus()
	{
	}

	protected virtual void UpdateRankBg()
	{
	}

	protected virtual void OnRefreshStatus()
	{
	}

	private void ClickChest()
	{
	}

	protected virtual void ClickUserInfo()
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

using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingRankRewardDetailItem : UITableViewCell
{
	[SerializeField]
	private DxxText ranking;

	[SerializeField]
	private Image rewardBg;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject decorateObj;

	[SerializeField]
	private Image decorate1;

	[SerializeField]
	private Image decorate2;

	private SailingRankRewardDetailItemData OldData;

	private ASSSDataParser.SailingRankRewardData data;

	private int curArea;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private string[] rewards;

	private RectTransform _scrollViewRect;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(ASSSDataParser.SailingRankRewardData data, int area, RectTransform scrollRect)
	{
	}

	private string[] GetRewards(int area)
	{
		return null;
	}

	private void RefreshText()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}
}

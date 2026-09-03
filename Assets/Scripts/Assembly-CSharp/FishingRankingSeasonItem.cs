using UIKit;
using UnityEngine;
using XLua;

public class FishingRankingSeasonItem : UITableViewCell
{
	[SerializeField]
	private ButtonCtrl detail;

	[SerializeField]
	private FishingRankingItem rankingItem;

	private FishingRankingSeasonItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_ClickDetail;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(FishingRankingSeasonItemData data, int curSelectIndex)
	{
	}

	private void ClickDetail()
	{
	}
}

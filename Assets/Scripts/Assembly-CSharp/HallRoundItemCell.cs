using UIKit;
using UnityEngine;
using XLua;

public class HallRoundItemCell : UITableViewCell
{
	public RectTransform Panel;

	public RectTransform Content;

	public DxxText Text_Title;

	public GameObject cpItem;

	private HalloweenRewardData data;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected new void Awake()
	{
	}

	public void init(HalloweenRewardData data)
	{
	}
}

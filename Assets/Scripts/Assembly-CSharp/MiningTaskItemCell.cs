using UIKit;
using UnityEngine;
using XLua;

public class MiningTaskItemCell : UITableViewCell
{
	public PropOneEquip[] propItems;

	public DxxText Text_Title;

	public DxxText Text_Progress;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Mask;

	public GameObject RedPoint;

	private MiningTaskItemData itemData;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonGet;

	private static DelegateBridge _c__Hotfix0_ctor;

	public new void Awake()
	{
	}

	public void init(MiningTaskItemData data)
	{
	}

	private void onButtonGet()
	{
	}
}

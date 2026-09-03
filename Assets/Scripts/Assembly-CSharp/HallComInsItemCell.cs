using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HallComInsItemCell : UITableViewCell
{
	public GameObject BG1;

	public GameObject BG2;

	public Image[] Icons;

	public Image[] Bgs;

	public Button button;

	public PropOneEquip propItem;

	public DxxText txtRate;

	private HalloweenComData data;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected new void Awake()
	{
	}

	public void init(HalloweenComData data)
	{
	}

	public void onButtonClick()
	{
	}
}

using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HallComItemCell : UITableViewCell
{
	public Image[] Icon;

	public GameObject Mask;

	public Button button;

	public GameObject Finish;

	private HalloweenComData data;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonOpenExch;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected new void Awake()
	{
	}

	public void init(HalloweenComData data)
	{
	}

	public void onButtonOpenExch()
	{
	}
}

using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorExchItemCell : UITableViewCell
{
	public GameObject BG1;

	public GameObject BG2;

	public GameObject BG3;

	public DxxText Text_Progress;

	public DxxText Text_Give;

	public Image[] NeedIcon;

	public DxxText[] NeedCount;

	public GameObject Mask;

	public GameObject Ratio;

	public DxxText Text_Ratio;

	private ManorExchData exchData;

	private bool fullMaterial;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(ManorExchData data)
	{
	}

	public void onButtonClick()
	{
	}
}

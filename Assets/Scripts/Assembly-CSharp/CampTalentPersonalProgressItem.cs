using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentPersonalProgressItem : UITableViewCell
{
	[SerializeField]
	private DxxText id;

	[SerializeField]
	private CampTalentPersonalProgressLine personalLine;

	[SerializeField]
	private Image icon1;

	[SerializeField]
	private Image icon2;

	[SerializeField]
	private Image frameType1;

	[SerializeField]
	private Image frameType2;

	[SerializeField]
	private GameObject frameType1Mask;

	[SerializeField]
	private GameObject frameType2Mask;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private Image circleBg;

	[SerializeField]
	private ButtonCtrl click;

	private CampTalentPersonalProgressItemData data;

	private Color type1TextColor;

	private Color type2TextColor;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshIcon;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampTalentPersonalProgressItemData data)
	{
	}

	public void RefreshRed()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshIcon()
	{
	}

	private void Click()
	{
	}
}

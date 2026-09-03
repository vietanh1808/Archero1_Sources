using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentTeamProgressItem : UITableViewCell
{
	[SerializeField]
	private GameObject leftItem;

	[SerializeField]
	private GameObject rightItem;

	[SerializeField]
	private ButtonCtrl leftClick;

	[SerializeField]
	private ButtonCtrl rightClick;

	[SerializeField]
	private Image leftIcon;

	[SerializeField]
	private Image rightIcon;

	[SerializeField]
	private DxxText leftNeedScore;

	[SerializeField]
	private DxxText rightNeedScore;

	[SerializeField]
	private DxxText leftTipName;

	[SerializeField]
	private DxxText leftBottomTipName;

	[SerializeField]
	private DxxText rightTipName;

	[SerializeField]
	private DxxText rightBottomTipName;

	[SerializeField]
	private DxxText leftTipDesc;

	[SerializeField]
	private DxxText leftBottomTipDesc;

	[SerializeField]
	private DxxText rightTipDesc;

	[SerializeField]
	private DxxText rightBottomTipDesc;

	[SerializeField]
	private ButtonCtrl leftTipBtn;

	[SerializeField]
	private ButtonCtrl leftBottomTipBtn;

	[SerializeField]
	private ButtonCtrl rightTipBtn;

	[SerializeField]
	private ButtonCtrl rightBottomTipBtn;

	[SerializeField]
	private Image leftBgIcon;

	[SerializeField]
	private Image rightBgIcon;

	[SerializeField]
	private Image leftNeedScoreIcon;

	[SerializeField]
	private Image rightNeedScoreIcon;

	[SerializeField]
	private Transform leftTipParent;

	[SerializeField]
	private Transform rightTipParent;

	private Transform tipParent;

	private CampTalentTeamProgressItemData data;

	private bool isLeftShowProp;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshLeft;

	private static DelegateBridge __Hotfix0_RefreshRight;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampTalentTeamProgressItemData data, bool isLeftShowProp, Transform tipParent)
	{
	}

	public void RefreshLeft()
	{
	}

	public void RefreshRight()
	{
	}
}

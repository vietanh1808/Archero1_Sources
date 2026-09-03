using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class AdHarvestLevelBtn : UITableViewCell
{
	[SerializeField]
	private DxxText levelText;

	[SerializeField]
	private Sprite[] bgs;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private ButtonCtrl btn;

	private int level;

	private bool isSelect;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(int curLevel, int level)
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshText()
	{
	}

	public void Click()
	{
	}
}

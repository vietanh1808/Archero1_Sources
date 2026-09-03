using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorWorkerItemCell : UITableViewCell
{
	public ManorStarsShow StarsShow;

	public Image Image_Worker;

	public Image Image_Build;

	public Image Image_BG;

	public GameObject Selected;

	private ManorWorkerData wkData;

	private int buildId;

	private ulong selectId;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(ManorWorkerData data, ulong selectId)
	{
	}

	public void onButtonClick()
	{
	}
}

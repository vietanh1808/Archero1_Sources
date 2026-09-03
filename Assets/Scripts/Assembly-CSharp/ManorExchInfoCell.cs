using UIKit;
using UnityEngine;
using XLua;

public class ManorExchInfoCell : UITableViewCell
{
	public HeadItem headItem;

	public DxxText Text_Level;

	public DxxText Text_Name;

	public DxxText Text_Time;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public GameObject LvBG;

	private ManorExchInfoData infoData;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonGo;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(ManorExchInfoData data)
	{
	}

	private void onButtonGo()
	{
	}
}

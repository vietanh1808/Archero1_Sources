using UIKit;
using UnityEngine;
using XLua;

public class ManorRecordItemCell : UITableViewCell
{
	public GameObject BG1;

	public GameObject BG2;

	public GameObject BG3;

	public HeadItem headItem;

	public GameObject headDefault;

	public GameObject LvBG;

	public DxxText Text_Level;

	public DxxText Text_Content;

	public DxxText Text_Time;

	public ButtonCtrl Button_Go;

	public DxxText Text_Go;

	public RectTransform Bottom;

	public ButtonCtrl Button_Info;

	public DxxText Text_Count;

	public GameObject Icon2;

	public GameObject Icon3;

	private ManorRecordItemData itemData;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonGo;

	private static DelegateBridge __Hotfix0_GetCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public new void Awake()
	{
	}

	public void init(ManorRecordItemData data)
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonGo()
	{
	}

	private int GetCount(ManorRecordItemData data)
	{
		return 0;
	}
}

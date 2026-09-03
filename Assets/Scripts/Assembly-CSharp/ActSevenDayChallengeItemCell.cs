using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActSevenDayChallengeItemCell : UITableViewCell
{
	public Slider slider;

	public Image bg_Img;

	public Image title_Img;

	public DxxText Slider_Title;

	public DxxText Slider_Count;

	public DxxText Text_xp;

	public DxxText Text_gems;

	public ButtonCtrl Button_Go;

	public ButtonCtrl Button_Get;

	public DxxText Text_Go;

	public DxxText Text_Get;

	public GameObject HaveGet;

	private SevenDayTaskData taskData;

	public PropOneEquip rewardItem;

	private List<PropOneEquip> items;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonGet;

	private static DelegateBridge __Hotfix0_GetTaskContentParam;

	private static DelegateBridge __Hotfix0_GetStringByAgrsType;

	private static DelegateBridge __Hotfix0_onButtonGo;

	private static DelegateBridge __Hotfix0_Lua_Hotfix;

	private static DelegateBridge _c__Hotfix0_ctor;

	public new void Awake()
	{
	}

	public void init(SevenDayTaskData data)
	{
	}

	private void onButtonGet()
	{
	}

	private List<string> GetTaskContentParam(SevenDayTaskData sdtd)
	{
		return null;
	}

	private string GetStringByAgrsType(int type, int value)
	{
		return null;
	}

	private void onButtonGo()
	{
	}

	public void Lua_Hotfix()
	{
	}
}

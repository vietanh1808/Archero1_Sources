using System;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActBossPlayItemCell : UITableViewCell
{
	private static Material _outLine;

	public GameObject Panel_Box;

	public GameObject Panel_Monster;

	public DxxText Text_BoxTitle;

	public DxxText Text_BoxBount;

	public DxxText Text_Key;

	public DxxText Text_Level;

	public Image Image_Build;

	public Image Image_Door;

	public GameObject Cloud;

	public GameObject[] Loader;

	public ButtonCtrl Button_Begin;

	public ButtonCtrl Button_Box;

	private BossPlayItemData data;

	private int enterBattleHave;

	public ButtonCtrl Button_Select;

	public Action<BossPlayItemData> selectCallBack;

	public GameObject arrowObj;

	private static DelegateBridge __Hotfix0_get_OutLineMaterial;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_SetSelectState;

	private static DelegateBridge __Hotfix0_onButtonBegin;

	private static DelegateBridge __Hotfix0_onButtonBox;

	private static DelegateBridge __Hotfix0_onButtonSelect;

	private static DelegateBridge __Hotfix0_enterBattle;

	private static DelegateBridge __Hotfix0_LoadMonster;

	private static DelegateBridge __Hotfix0_close3D;

	private static DelegateBridge __Hotfix0_Lua_Hotfix;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static Material OutLineMaterial => null;

	public new void Awake()
	{
	}

	public void init(BossPlayItemData data)
	{
	}

	public void SetSelectState()
	{
	}

	private void onButtonBegin()
	{
	}

	private void onButtonBox()
	{
	}

	private void onButtonSelect()
	{
	}

	private void enterBattle()
	{
	}

	public void LoadMonster(int charid, GameObject obj)
	{
	}

	public void close3D()
	{
	}

	public void Lua_Hotfix()
	{
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopItemGold : MonoBehaviour
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Get;

	public Image Image_Icon;

	public DxxText Text_Count;

	public DxxText Text_Bonus;

	public GoldTextCtrl mGoldCtrl;

	public GameObject goBonus;

	public Action<int, ShopItemGold> OnClickButton;

	public DxxText Text_VipAdd;

	protected int mIndex;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnInitOnce;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_GetGold;

	private static DelegateBridge __Hotfix0_GetGoldTime;

	private static DelegateBridge __Hotfix0_GetDiamond;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnButtonClick;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	protected virtual void OnInitOnce()
	{
	}

	public virtual void Init(int index)
	{
	}

	public virtual int GetGold()
	{
		return 0;
	}

	public virtual int GetGoldTime()
	{
		return 0;
	}

	public virtual int GetDiamond()
	{
		return 0;
	}

	public void OnLanguageChange()
	{
	}

	public virtual void OnButtonClick()
	{
	}

	public void UpdateNet()
	{
	}
}

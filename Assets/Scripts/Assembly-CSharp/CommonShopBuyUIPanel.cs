using System;
using UnityEngine.UI;
using XLua;

public class CommonShopBuyUIPanel : MediatorCtrlBase
{
	public class ShopData
	{
		public int GiveType;

		public int GiveID;

		public int GiveNum;

		public int NeedType;

		public int NeedID;

		public int NeedNum;

		public int Have;

		public int Left;

		public Func<bool> ClickDo;
	}

	public DxxText Text_Title;

	public DxxText Text_TitleSub;

	public DxxText Text_Count;

	public DxxText Text_Need;

	public Image Image_Icon;

	public PropOneEquip prop;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Back;

	private static DelegateBridge __Hotfix0_get_data;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonBuy;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ShopData data => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void onButtonBuy()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}

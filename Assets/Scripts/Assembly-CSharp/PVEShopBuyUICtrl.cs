using PureMVC.Interfaces;
using UnityEngine;

public class PVEShopBuyUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_TitleSub;

	public DxxText Text_Count;

	public DxxText Text_Need;

	public GameObject Image_Icon2;

	public GameObject Image_Icon12;

	public GameObject Image_Icon32;

	public PropOneEquip prop;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Back;

	private PVEShopDataNormal data;

	private int sdkscore;

	private int sdkgems;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void init()
	{
	}

	public void onButtonBuy()
	{
	}
}

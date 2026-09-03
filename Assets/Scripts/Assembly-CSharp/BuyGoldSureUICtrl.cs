using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BuyGoldSureUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public GoldTextCtrl mGoldCtrl;

	public Image Image_Icon;

	public DxxText Text_Count;

	public DxxText Text_Bonus;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Refuse;

	public ButtonCtrl Button_Shadow;

	public GameObject goBonus;

	public GameObject goPlus;

	public GameObject vipAdd;

	public GameObject vipPlus;

	public DxxText Text_VIP;

	public DxxText Text_Desc1;

	public DxxText Text_Desc2;

	private BuyGoldSureProxy.Transfer mTransfer;

	private Shop_Shop shopdata;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void android_escape()
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
}

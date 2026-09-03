using PureMVC.Interfaces;
using TableTool;
using UnityEngine.UI;

public class BuySkinSureUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public GoldTextCtrl mGoldCtrl;

	public Image Image_Icon;

	public DxxText Text_Count;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Refuse;

	public ButtonCtrl Button_Shadow;

	private BuySkinSureProxy.Transfer mTransfer;

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

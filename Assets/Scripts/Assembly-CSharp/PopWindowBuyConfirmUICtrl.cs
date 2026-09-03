using PureMVC.Interfaces;
using UnityEngine.UI;

public class PopWindowBuyConfirmUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public Image Image_Icon;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public DxxImage[] Image_Title;

	public Image[] Image_Bg;

	private PopWindowBuyConfirmProxy.Transfer mTransfer;

	private float contenty;

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

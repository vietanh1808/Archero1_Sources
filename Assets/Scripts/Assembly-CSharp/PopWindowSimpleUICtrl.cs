using PureMVC.Interfaces;

public class PopWindowSimpleUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public TapToCloseCtrl mTapCloseCtrl;

	public DxxText Text_Content;

	private PopWindowSimpleProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

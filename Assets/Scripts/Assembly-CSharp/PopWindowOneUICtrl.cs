using PureMVC.Interfaces;

public class PopWindowOneUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	private PopWindowOneProxy.Transfer mTransfer;

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

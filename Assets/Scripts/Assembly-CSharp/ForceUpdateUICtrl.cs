using PureMVC.Interfaces;

public class ForceUpdateUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public ButtonCtrl Button_Sure;

	private ChangeAccountProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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

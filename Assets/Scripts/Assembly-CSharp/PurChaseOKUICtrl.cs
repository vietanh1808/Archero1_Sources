using PureMVC.Interfaces;

public class PurChaseOKUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_ID;

	public DxxText Text_Receipt;

	public ScrollRectBase mScrollRect;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	private LocalUnityObjctPool mPool;

	private PurChaseOKProxy.Transfer mTransfer;

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

using PureMVC.Interfaces;

public class SailingOpenUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public DxxText[] Text_Desc;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

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

	private void Esc()
	{
	}

	public void onButtonOK()
	{
	}
}

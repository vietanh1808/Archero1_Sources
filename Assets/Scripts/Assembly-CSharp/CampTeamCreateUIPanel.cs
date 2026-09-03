using PureMVC.Interfaces;

public class CampTeamCreateUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Team;

	public DxxText Text_Info;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Back;

	public DxxText Text_Back;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	public DxxText Text_Diamond;

	public DxxInput mInput;

	public DxxText Text_InputTips;

	private string endInputText;

	private int needDiamond;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void Esc()
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

	public void onButtonOK()
	{
	}

	private void onInputEnd(string text)
	{
	}

	private void onInputEdited(string text)
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonClose()
	{
	}

	private void checkShowTips()
	{
	}
}

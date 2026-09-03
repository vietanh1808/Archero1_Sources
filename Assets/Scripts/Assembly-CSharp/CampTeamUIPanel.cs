using PureMVC.Interfaces;

public class CampTeamUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Name;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Dismiss;

	public DxxText Text_Dismiss;

	public ButtonCtrl Button_Invite;

	public DxxText Text_Invite;

	public ButtonCtrl Button_Privilege;

	public DxxText Text_Privilege;

	public ButtonCtrl Button_Info;

	public CampTeamCharItem[] charItems;

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

	private void initUI()
	{
	}

	private void onButtonDismiss()
	{
	}

	private void onButtonInvite()
	{
	}

	private void onButtonPrivilege()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}
}

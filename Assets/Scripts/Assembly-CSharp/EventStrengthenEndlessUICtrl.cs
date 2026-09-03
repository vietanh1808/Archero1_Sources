using Dxx.Util;
using PureMVC.Interfaces;

public class EventStrengthenEndlessUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Content;

	public DxxImage Image_Icon;

	public DxxImage Image_IconBG;

	public ButtonCtrl mAcceptButton;

	public DxxText mSkillNameText;

	public DxxText Text_Get;

	private int skillid;

	private int type;

	private SequencePool mSeqPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void close_show(bool value)
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

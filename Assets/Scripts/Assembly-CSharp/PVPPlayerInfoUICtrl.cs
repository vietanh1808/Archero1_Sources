using PureMVC.Interfaces;
using UnityEngine.UI;

public class PVPPlayerInfoUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_ID;

	public Text Text_Name;

	public HeadItemOne headItem;

	public DxxText[] Text_Key;

	public DxxText[] Text_Value;

	public ButtonCtrl Button_Close;

	public MedalItem medalItem;

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

	private void android_escape()
	{
	}
}

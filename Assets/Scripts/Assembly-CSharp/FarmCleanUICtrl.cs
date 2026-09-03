using PureMVC.Interfaces;
using UnityEngine;

public class FarmCleanUICtrl : MediatorCtrlBase
{
	public class ShowData
	{
		public int windowId;

		public int eventId;
	}

	public GameObject[] popWindow;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_OK;

	public ButtonCtrl Button_Cost;

	public GoldTextCtrl costTextCtrl;

	[HideInInspector]
	public int windowId;

	[HideInInspector]
	public int eventId;

	public DxxText Text_W0_Line1;

	public DxxText Text_W0_Line2;

	public DxxText Text_W1_Line1;

	public DxxText Text_W1_Line2;

	public DxxText Text_W2_Line1;

	public DxxText Text_W2_Line2;

	public DxxText Text_W3_Line1;

	public DxxText Text_W3_Line2;

	public DxxText Text_W4_Line1;

	public DxxText Text_W5_Line1;

	public DxxText Text_W5_Line2;

	public GameObject box;

	public GameObject boxAni;

	public DxxText Text_Button;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void openWindow(int wid, int eid)
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

	public void android_escape()
	{
	}

	private void onButtonOK()
	{
	}
}

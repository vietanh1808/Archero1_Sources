using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EggProgressUICtrl : MediatorCtrlBase
{
	public class Transfer
	{
		public LocalSave.EggData data;

		public int scene;

		public int Location;
	}

	public DxxText Text_Title;

	public DxxText Kill_Hatch;

	public DxxText Kill_Desc;

	public Slider Kill_Slider;

	public DxxText Kill_Progress;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Go;

	public DxxText Text_ButtonGo;

	public GameObject Loader;

	private int Location;

	private LocalSave.EggData data;

	private int monsterid;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	public void init()
	{
	}
}

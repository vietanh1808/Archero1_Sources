using PureMVC.Interfaces;
using UnityEngine;

public class CommonPopInfoUICtrl : MediatorCtrlBase
{
	public class PopData
	{
		public Vector3 position;

		public string desc;

		public bool top;

		public int width;

		public int textAlign;

		public int style;

		public bool isCheckOffset;
	}

	public GameObject Style0;

	public GameObject Style1;

	public GameObject Style2;

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

	public void onButtonClose()
	{
	}
}

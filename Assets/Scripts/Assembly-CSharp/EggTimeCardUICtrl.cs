using PureMVC.Interfaces;
using UnityEngine;

public class EggTimeCardUICtrl : MediatorCtrlBase
{
	public class Transfer
	{
		public LocalSave.EggData data;

		public int scene;

		public int Location;
	}

	public EggTimePanelOne PanelOne;

	public EggTimePanelTwo PanelTwo;

	public Transfer tfData;

	public RectTransform Offset;

	public RectTransform Panel;

	public RectTransform Panel1;

	public RectTransform Panel2;

	private float MoveX;

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

	public void showTab(int tab)
	{
	}
}

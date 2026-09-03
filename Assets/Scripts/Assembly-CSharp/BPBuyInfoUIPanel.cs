using PureMVC.Interfaces;
using UnityEngine;

public class BPBuyInfoUIPanel : MediatorCtrlBase
{
	public class TipsData
	{
		public Vector3 position;
	}

	public GameObject Arrow;

	public DxxText Text_Info;

	public DxxText Text_Star;

	public RectTransform Content;

	public GameObject cpItem;

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

	public void onButtonClose()
	{
	}
}

using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class CommonPopRewardUIPanel : MediatorCtrlBase
{
	public class PopData
	{
		public Vector3 position;

		public List<string> rewards;

		public int style;
	}

	public GameObject[] Arrow;

	public RectTransform[] RT_BG;

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

	private void android_escape()
	{
	}

	public void onButtonClose()
	{
	}
}

using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class InstructionUICtrl : MediatorCtrlBase
{
	public class InsData
	{
		public string title;

		public string content;
	}

	public DxxText Text_Title;

	public DxxText Text_Content;

	public RectTransform Container;

	private ScrollRect scrollRect;

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

	public void onButtonTouchScreen()
	{
	}
}

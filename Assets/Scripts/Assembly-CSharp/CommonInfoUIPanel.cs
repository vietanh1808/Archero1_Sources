using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CommonInfoUIPanel : MediatorCtrlBase
{
	public class InsData
	{
		public string title;

		public string content;

		public int style;

		public int height;

		public static InsData Create(string title, string content, int style)
		{
			return null;
		}
	}

	public DxxText Text_Title;

	public DxxText Text_Content;

	public ButtonCtrl Button_Close;

	public RectTransform Container;

	public RectTransform Panel;

	public GameObject[] BG;

	public GameObject[] TitleBG;

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

	private void Esc()
	{
	}

	public void onButtonTouchScreen()
	{
	}
}

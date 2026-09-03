using PureMVC.Interfaces;
using UnityEngine;

public class MainUIPageChar : UIBase
{
	private const string _uiPath = "UIPanel/MainUI/1CharNew";

	private MediatorCtrlBase ctrl;

	private ScrollRectBase mMainScroll;

	public MainUIPageChar(Transform parent, ScrollRectBase scroll)
		: base(null)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	public override void PreloadRes()
	{
	}
}

using PureMVC.Interfaces;
using UnityEngine;

public class MainUIPage4 : UIBase
{
	private const string _uiPath = "UIPanel/MainUI/4Activity";

	private MediatorCtrlBase ctrl;

	private ButtonCtrl mButtonStart;

	public MainUIPage4(Transform parent)
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

using PureMVC.Interfaces;
using UnityEngine;

public class MainUIPage3 : UIBase
{
	private const string _uiPath = "UIPanel/MainUI/3Card";

	private MediatorCtrlBase ctrl;

	private ButtonCtrl mButtonStart;

	private bool LoginExchanged => false;

	public bool CanShowExchange => false;

	public MainUIPage3(Transform parent)
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

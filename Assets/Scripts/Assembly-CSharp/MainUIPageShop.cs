using PureMVC.Interfaces;
using UnityEngine;

public class MainUIPageShop : UIBase
{
	private const string _uiPath = "UIPanel/MainUI/0Shop";

	private MediatorCtrlBase _ctrl;

	private ScrollRectBase mMainScroll;

	private MediatorCtrlBase mCtrl => null;

	public bool CanShowChapterUpgrade => false;

	public MainUIPageShop(Transform parent, ScrollRectBase scroll)
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

	public override void OnLanguageChange()
	{
	}

	public override void PreloadRes()
	{
	}
}

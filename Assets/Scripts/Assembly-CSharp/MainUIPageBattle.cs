using PureMVC.Interfaces;
using UnityEngine;

public class MainUIPageBattle : UIBase
{
	private MediatorCtrlBase mCtrl;

	public MainUIPageBattle(Transform parent)
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

	public override object OnGetEvent(string eventName)
	{
		return null;
	}
}

using System.Collections.Generic;
using PureMVC.Interfaces;

public class MazeFoodMagicianUIMediator : WindowMediator, IMediator, INotifier
{
	private MazeFoodMagicianUICtl uictl;

	public override List<string> OnListNotificationInterests => null;

	public MazeFoodMagicianUIMediator()
		: base(null)
	{
	}

	protected override void OnRegisterBefore()
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	protected override void OnRemoveAfter()
	{
	}

	protected override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}

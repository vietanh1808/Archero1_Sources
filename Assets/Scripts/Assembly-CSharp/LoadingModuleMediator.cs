using System.Collections.Generic;
using PureMVC.Interfaces;

public class LoadingModuleMediator : WindowMediator, IMediator, INotifier
{
	public override List<string> OnListNotificationInterests => null;

	public LoadingModuleMediator()
		: base(null)
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

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnLanguageChange()
	{
	}
}

using System.Collections.Generic;
using PureMVC.Interfaces;

public class UpdateAssetUIMediator : WindowMediator, IMediator, INotifier
{
	private UpdateAssetCtl updateAssetCtl;

	public override List<string> OnListNotificationInterests => null;

	public UpdateAssetUIMediator()
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

using System.Collections.Generic;
using Emoji;
using PureMVC.Interfaces;

public class EmojiObjectManagerUIMediator : WindowMediator, IMediator, INotifier
{
	private EmojiObjectManagerCtl ctl;

	public override List<string> OnListNotificationInterests => null;

	public EmojiObjectManagerUIMediator()
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

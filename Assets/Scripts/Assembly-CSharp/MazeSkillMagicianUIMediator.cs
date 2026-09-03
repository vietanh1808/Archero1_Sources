using System.Collections.Generic;
using PureMVC.Interfaces;

public class MazeSkillMagicianUIMediator : WindowMediator, IMediator, INotifier
{
	private MazeSkillMagicianUICtl uictl;

	public override List<string> OnListNotificationInterests => null;

	public MazeSkillMagicianUIMediator()
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

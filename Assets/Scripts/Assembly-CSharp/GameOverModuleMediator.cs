using System.Collections.Generic;
using PureMVC.Interfaces;

public class GameOverModuleMediator : WindowMediator, IMediator, INotifier
{
	public new const string NAME = "GameOverModuleMediator";

	private static Dictionary<GameMode, MediatorCtrlBase> mModeCtrlList;

	private static MediatorCtrlBase mCurrentModeCtrl;

	public override List<string> OnListNotificationInterests => null;

	public GameOverModuleMediator()
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

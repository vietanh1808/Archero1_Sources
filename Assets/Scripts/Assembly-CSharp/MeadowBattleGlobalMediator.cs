using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class MeadowBattleGlobalMediator : Mediator
{
	public new const string NAME = "MeadowBattleGlobalMediator";

	public override IEnumerable<string> ListNotificationInterests => null;

	public MeadowBattleGlobalMediator(string name, object view)
	{
	}

	public override void OnRegister()
	{
	}

	public override void OnRemove()
	{
	}

	public override void HandleNotification(INotification notification)
	{
	}

	private void onShowMBPageFromMainUI()
	{
	}

	private void onShowNetError()
	{
	}

	private void onCheckCustomAttack()
	{
	}
}

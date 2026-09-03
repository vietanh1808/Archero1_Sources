using System.Collections.Generic;
using PureMVC.Interfaces;

public class SuperRouletteUIMediator : MediatorBase
{
	public new const string NAME = "SuperRouletteUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SuperRouletteUIMediator()
		: base(null)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}

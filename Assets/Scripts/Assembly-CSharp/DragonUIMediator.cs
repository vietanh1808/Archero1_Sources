using System.Collections.Generic;
using PureMVC.Interfaces;

public class DragonUIMediator : MediatorBase
{
	public new const string NAME = "DragonUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public DragonUIMediator()
		: base(null)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}

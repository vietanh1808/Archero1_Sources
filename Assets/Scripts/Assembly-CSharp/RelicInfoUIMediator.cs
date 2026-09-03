using System.Collections.Generic;
using PureMVC.Interfaces;

public class RelicInfoUIMediator : MediatorBase
{
	public new const string NAME = "RelicInfoUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public RelicInfoUIMediator()
		: base(null)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onClickForge(int relicId)
	{
	}
}

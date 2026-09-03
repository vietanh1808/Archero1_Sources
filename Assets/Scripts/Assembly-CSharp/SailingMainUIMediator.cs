using System.Collections.Generic;

public class SailingMainUIMediator : MediatorBase
{
	public new const string NAME = "SailingMainUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingMainUIMediator()
		: base(null)
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	protected override void OnRemoveAfter()
	{
	}
}

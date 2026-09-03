using System.Collections.Generic;

public class BallonAdUIMediator : MediatorBase
{
	public new const string NAME = "BallonAdUIGetMediator";

	public override List<string> OnListNotificationInterests => null;

	public BallonAdUIMediator()
		: base(null)
	{
	}
}

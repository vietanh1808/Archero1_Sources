using System.Collections.Generic;

public class MazeExchangeMediator : MediatorBase
{
	public new const string NAME = "MazeExchangeMediator";

	public override List<string> OnListNotificationInterests => null;

	public MazeExchangeMediator()
		: base(null)
	{
	}
}

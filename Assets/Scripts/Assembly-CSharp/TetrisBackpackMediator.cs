using System.Collections.Generic;

public class TetrisBackpackMediator : MediatorBase
{
	public new const string NAME = "TetrisBackpackMediator";

	public override List<string> OnListNotificationInterests => null;

	public TetrisBackpackMediator()
		: base(null)
	{
	}

	public override bool PreloadRes()
	{
		return false;
	}
}

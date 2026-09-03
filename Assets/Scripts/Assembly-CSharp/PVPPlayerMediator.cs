using System.Collections.Generic;

public class PVPPlayerMediator : MediatorBase
{
	public new const string NAME = "PVPPlayerMediator";

	public override List<string> OnListNotificationInterests => null;

	public PVPPlayerMediator()
		: base(null)
	{
	}

	public override bool PreloadRes()
	{
		return false;
	}
}

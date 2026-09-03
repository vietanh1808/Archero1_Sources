using System.Collections.Generic;

public class EggActivityMediator : MediatorBase
{
	public new const string NAME = "EggActivityMediator";

	public override List<string> OnListNotificationInterests => null;

	public EggActivityMediator()
		: base(null)
	{
	}

	public override bool PreloadRes()
	{
		return false;
	}
}

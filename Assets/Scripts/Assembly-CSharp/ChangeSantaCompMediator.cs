using System.Collections.Generic;

public class ChangeSantaCompMediator : MediatorBase
{
	public new const string NAME = "ChangeSantaCompUIPanel";

	public override List<string> OnListNotificationInterests => null;

	public ChangeSantaCompMediator()
		: base(null)
	{
	}
}

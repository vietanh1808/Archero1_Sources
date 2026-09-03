using System.Collections.Generic;

public class DeepSeaMonsterMediator : MediatorBase
{
	public new const string NAME = "DeepSeaMonsterMediator";

	public override List<string> OnListNotificationInterests => null;

	public DeepSeaMonsterMediator()
		: base(null)
	{
	}
}

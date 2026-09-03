using System.Collections.Generic;

public class ChooseMonsterBuffMediator : MediatorBase
{
	public new const string NAME = "ChooseMonsterBuffMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseMonsterBuffMediator()
		: base(null)
	{
	}
}

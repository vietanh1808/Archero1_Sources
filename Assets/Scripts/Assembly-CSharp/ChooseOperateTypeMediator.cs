using System.Collections.Generic;

public class ChooseOperateTypeMediator : MediatorBase
{
	public new const string NAME = "ChooseOperateTypeMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseOperateTypeMediator()
		: base(null)
	{
	}
}

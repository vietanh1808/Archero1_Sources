using System.Collections.Generic;

public class CommonSecondTipsMediator : MediatorBase
{
	public new const string NAME = "CommonSecondTipsMediator";

	public override List<string> OnListNotificationInterests => null;

	public CommonSecondTipsMediator()
		: base(null)
	{
	}
}

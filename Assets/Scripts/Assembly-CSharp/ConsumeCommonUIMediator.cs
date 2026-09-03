using System.Collections.Generic;

public class ConsumeCommonUIMediator : MediatorBase
{
	public const string Name = "ConsumeCommonUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ConsumeCommonUIMediator()
		: base(null)
	{
	}
}

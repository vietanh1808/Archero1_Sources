using System.Collections.Generic;

public class EggTimeConfirmUIMediator : MediatorBase
{
	public new const string NAME = "EggTimeConfirmUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public EggTimeConfirmUIMediator()
		: base(null)
	{
	}
}

using System.Collections.Generic;

public class CampKingScrambleArrowMediator : MediatorBase
{
	public new const string NAME = "CampKingScrambleArrowMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampKingScrambleArrowMediator()
		: base(null)
	{
	}
}

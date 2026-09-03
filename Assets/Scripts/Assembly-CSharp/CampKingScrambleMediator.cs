using System.Collections.Generic;

public class CampKingScrambleMediator : MediatorBase
{
	public new const string NAME = "CampKingScrambleMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampKingScrambleMediator()
		: base(null)
	{
	}
}

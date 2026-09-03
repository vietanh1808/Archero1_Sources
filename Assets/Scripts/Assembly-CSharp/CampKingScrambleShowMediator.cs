using System.Collections.Generic;

public class CampKingScrambleShowMediator : MediatorBase
{
	public new const string NAME = "CampKingScrambleShowMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampKingScrambleShowMediator()
		: base(null)
	{
	}
}

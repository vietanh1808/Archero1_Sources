using System.Collections.Generic;

public class CampKingScrambleRankingMediator : MediatorBase
{
	public new const string NAME = "CampKingScrambleRankingMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampKingScrambleRankingMediator()
		: base(null)
	{
	}
}

using System.Collections.Generic;

public class TalentScoreMediator : MediatorBase
{
	public new const string NAME = "TalentScoreMediator";

	public override List<string> OnListNotificationInterests => null;

	public TalentScoreMediator()
		: base(null)
	{
	}
}

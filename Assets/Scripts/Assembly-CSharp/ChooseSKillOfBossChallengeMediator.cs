using System.Collections.Generic;

public class ChooseSKillOfBossChallengeMediator : MediatorBase
{
	public new const string NAME = "ChooseSKillOfBossChallengeMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChooseSKillOfBossChallengeMediator()
		: base(null)
	{
	}
}

using System.Collections.Generic;

public class PlayerStageChapterMediator : MediatorBase
{
	public new const string NAME = "PlayerStageChapterMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlayerStageChapterMediator()
		: base(null)
	{
	}
}

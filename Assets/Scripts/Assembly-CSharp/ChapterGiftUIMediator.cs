using System.Collections.Generic;

public class ChapterGiftUIMediator : MediatorBase
{
	public new const string NAME = "ChapterGiftUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ChapterGiftUIMediator()
		: base(null)
	{
	}
}

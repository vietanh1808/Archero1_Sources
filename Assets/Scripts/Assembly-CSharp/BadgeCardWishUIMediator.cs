using System.Collections.Generic;

public class BadgeCardWishUIMediator : MediatorBase
{
	public new const string NAME = "BadgeCardWishUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeCardWishUIMediator()
		: base(null)
	{
	}
}

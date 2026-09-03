using System.Collections.Generic;

public class GodWishUIMediator : MediatorBase
{
	public new const string NAME = "GodWishUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GodWishUIMediator()
		: base(null)
	{
	}
}

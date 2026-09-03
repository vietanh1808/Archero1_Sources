using System.Collections.Generic;

public class CampMatExchangeUIMediator : MediatorBase
{
	public new const string NAME = "CampTownMatExchangeMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampMatExchangeUIMediator()
		: base(null)
	{
	}
}

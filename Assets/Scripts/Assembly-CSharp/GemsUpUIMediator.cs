using System.Collections.Generic;

public class GemsUpUIMediator : MediatorBase
{
	public new const string NAME = "GemsUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GemsUpUIMediator()
		: base(null)
	{
	}
}

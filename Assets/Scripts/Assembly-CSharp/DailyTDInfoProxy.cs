using PureMVC.Patterns;

public class DailyTDInfoProxy : Proxy
{
	public class Transfer
	{
		public string title;

		public string content;
	}

	public new const string NAME = "DailyTDInfoProxy";

	public DailyTDInfoProxy(object data)
	{
	}
}

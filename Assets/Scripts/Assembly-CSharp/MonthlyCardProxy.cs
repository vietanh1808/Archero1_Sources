using PureMVC.Patterns;

public class MonthlyCardProxy : Proxy
{
	public class Transfer
	{
		public bool pop;

		public bool premium;
	}

	public new const string NAME = "MonthlyCardProxy";

	public MonthlyCardProxy(object data)
	{
	}
}

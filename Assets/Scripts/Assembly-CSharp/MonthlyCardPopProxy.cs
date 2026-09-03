using PureMVC.Patterns;

public class MonthlyCardPopProxy : Proxy
{
	public class Transfer
	{
		public bool premium;
	}

	public new const string NAME = "MonthlyCardPopProxy";

	public MonthlyCardPopProxy(object data)
	{
	}
}

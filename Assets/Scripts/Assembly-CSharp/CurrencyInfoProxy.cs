using PureMVC.Patterns;

public class CurrencyInfoProxy : Proxy
{
	public class Transfer
	{
		public int id;

		public long cnt;

		public bool showNum;

		public PropType type;
	}

	public new const string NAME = "CurrencyInfoProxy";

	public CurrencyInfoProxy(object data)
	{
	}
}

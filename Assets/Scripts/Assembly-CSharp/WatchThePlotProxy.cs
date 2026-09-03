using PureMVC.Patterns;

public class WatchThePlotProxy : Proxy
{
	public class Transfer
	{
		public string text;

		public float time;

		public Transfer(string text, float time)
		{
		}
	}

	public new const string NAME = "ValentineBabyProxy";

	public WatchThePlotProxy(object data)
	{
	}
}

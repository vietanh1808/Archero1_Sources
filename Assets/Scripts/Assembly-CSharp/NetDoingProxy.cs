using PureMVC.Patterns;

public class NetDoingProxy : Proxy
{
	public class Transfer
	{
		public NetDoingType type;

		public float delayTime;

		public float delayTime2;

		public float closeTime;
	}

	public new const string NAME = "NetDoingProxy";

	public NetDoingProxy(object data)
	{
	}
}

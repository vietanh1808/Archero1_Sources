using PureMVC.Patterns;

public class HeadAndFrameInfoProxy : Proxy
{
	public class Transfer
	{
		public int id;

		public int type;
	}

	public new const string NAME = "HeadInfoProxy";

	public HeadAndFrameInfoProxy(object data)
	{
	}
}

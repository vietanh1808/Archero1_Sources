using PureMVC.Patterns;

public class GuildActivityProxy : Proxy
{
	public class Transfer
	{
		public int id;
	}

	public new const string NAME = "GuildActivityProxy";

	public GuildActivityProxy(object data)
	{
	}
}

using Habby.Guild.Data;
using PureMVC.Patterns;

public class GuildInfoProxy : Proxy
{
	public class Transfer
	{
		public GuildInfoData data;
	}

	public new const string NAME = "GuildInfoProxy";

	public GuildInfoProxy(object data)
	{
	}
}

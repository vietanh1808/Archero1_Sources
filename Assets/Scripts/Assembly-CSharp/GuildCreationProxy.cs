using Habby.Guild.Data;
using PureMVC.Patterns;

public class GuildCreationProxy : Proxy
{
	public class Transfer
	{
		public GuildInfoData data;
	}

	public new const string NAME = "GuildCreationProxy";

	public GuildCreationProxy(object data)
	{
	}
}

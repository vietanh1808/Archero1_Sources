using Habby.Guild.Data;
using PureMVC.Patterns;

public class GuildSuggestionProxy : Proxy
{
	public class Transfer
	{
		public GuildInfoData fromGuildData;
	}

	public new const string NAME = "GuildSuggestionProxy";

	public GuildSuggestionProxy(object data)
	{
	}
}

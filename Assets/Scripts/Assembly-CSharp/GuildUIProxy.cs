using PureMVC.Patterns;

public class GuildUIProxy : Proxy
{
	public class Transfer
	{
		public GuildUICtrl.GuildTab openTab;
	}

	public new const string NAME = "GuildUIProxy";

	public GuildUIProxy(object data)
	{
	}
}

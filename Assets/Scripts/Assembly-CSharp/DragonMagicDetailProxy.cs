using PureMVC.Patterns;

public class DragonMagicDetailProxy : Proxy
{
	public class Transfer
	{
		public ulong rowId;

		public byte openType;

		public const byte DRAGON_UI = 1;

		public const byte CHAR_UI = 2;
	}

	public new const string NAME = "DragonMagicDetailProxy";

	public DragonMagicDetailProxy(Transfer data)
	{
	}
}

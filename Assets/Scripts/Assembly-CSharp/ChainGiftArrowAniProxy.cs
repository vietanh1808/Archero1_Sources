using PureMVC.Patterns;

public class ChainGiftArrowAniProxy : Proxy
{
	public class Transfer
	{
		public int index;

		public bool isActive;
	}

	public new const string NAME = "ChainGiftArrowAniProxy";

	public ChainGiftArrowAniProxy(object data)
	{
	}
}

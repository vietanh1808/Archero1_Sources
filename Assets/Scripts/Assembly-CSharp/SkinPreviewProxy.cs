using PureMVC.Patterns;

public class SkinPreviewProxy : Proxy
{
	public class Transfer
	{
		public int id;

		public int days;

		public int colorID;

		public int from;
	}

	public new const string NAME = "SkinPreviewProxy";

	public SkinPreviewProxy(object data)
	{
	}
}

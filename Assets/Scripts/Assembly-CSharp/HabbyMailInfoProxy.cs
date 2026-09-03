using Habby.Model;
using PureMVC.Patterns;

public class HabbyMailInfoProxy : Proxy
{
	public enum EMailPopType
	{
		eNormal = 0,
		eMain = 1
	}

	public class Transfer
	{
		public MailData data;

		public HabbyMailOneCtrl ctrl;

		public EMailPopType poptype;
	}

	public new const string NAME = "HabbyMailInfoProxy";

	public HabbyMailInfoProxy(object data)
	{
	}
}

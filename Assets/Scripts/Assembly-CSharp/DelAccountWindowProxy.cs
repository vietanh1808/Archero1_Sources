using PureMVC.Patterns;

public class DelAccountWindowProxy : Proxy
{
	public class Transfer
	{
		private int m_nConfirmCnt;

		public int ConfirmCnt => 0;
	}

	public new const string NAME = "DelAccountWindowProxy";

	public DelAccountWindowProxy(object data)
	{
	}
}

using PureMVC.Patterns;

public class SharedGuildGiftProxy : Proxy
{
	public class Transfer
	{
		public int RedEnvelopeId { get; private set; }

		public int RedEnvelopeForCashId { get; private set; }

		public Transfer(string id)
		{
		}

		public Transfer(int nRedEnvelopeForCashId, int nRedEnvelopeId)
		{
		}
	}

	public new const string NAME = "SharedGuildGiftProxy";

	public SharedGuildGiftProxy(object data)
	{
	}
}

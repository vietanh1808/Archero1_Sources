using Org.BouncyCastle.Asn1.Cmp;

namespace Org.BouncyCastle.Cmp
{
	public class GeneralPkiMessage
	{
		private readonly PkiMessage pkiMessage;

		public PkiHeader Header => null;

		public PkiBody Body => null;

		public bool HasProtection => false;

		private static PkiMessage ParseBytes(byte[] encoding)
		{
			return null;
		}

		public GeneralPkiMessage(PkiMessage pkiMessage)
		{
		}

		public GeneralPkiMessage(byte[] encoding)
		{
		}

		public PkiMessage ToAsn1Structure()
		{
			return null;
		}
	}
}

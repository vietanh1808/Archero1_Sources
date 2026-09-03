using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	public class ProtectedPkiMessage
	{
		private readonly PkiMessage pkiMessage;

		public PkiHeader Header => null;

		public PkiBody Body => null;

		public bool HasPasswordBasedMacProtected => false;

		public ProtectedPkiMessage(GeneralPkiMessage pkiMessage)
		{
		}

		public ProtectedPkiMessage(PkiMessage pkiMessage)
		{
		}

		public PkiMessage ToAsn1Message()
		{
			return null;
		}

		public X509Certificate[] GetCertificates()
		{
			return null;
		}

		public bool Verify(IVerifierFactory verifierFactory)
		{
			return false;
		}

		private object Process(IStreamCalculator streamCalculator)
		{
			return null;
		}

		public bool Verify(PKMacBuilder pkMacBuilder, char[] password)
		{
			return false;
		}
	}
}

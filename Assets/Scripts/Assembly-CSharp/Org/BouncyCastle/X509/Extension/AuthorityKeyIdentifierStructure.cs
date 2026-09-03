using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.X509.Extension
{
	public class AuthorityKeyIdentifierStructure : AuthorityKeyIdentifier
	{
		public AuthorityKeyIdentifierStructure(Asn1OctetString encodedValue)
			: base((Asn1Sequence)null)
		{
		}

		private static Asn1Sequence FromCertificate(X509Certificate certificate)
		{
			return null;
		}

		private static Asn1Sequence FromKey(AsymmetricKeyParameter pubKey)
		{
			return null;
		}

		public AuthorityKeyIdentifierStructure(X509Certificate certificate)
			: base((Asn1Sequence)null)
		{
		}

		public AuthorityKeyIdentifierStructure(AsymmetricKeyParameter pubKey)
			: base((Asn1Sequence)null)
		{
		}
	}
}

using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Cmp
{
	public class RevocationDetailsBuilder
	{
		private readonly CertTemplateBuilder _templateBuilder;

		public RevocationDetailsBuilder SetPublicKey(SubjectPublicKeyInfo publicKey)
		{
			return null;
		}

		public RevocationDetailsBuilder SetIssuer(X509Name issuer)
		{
			return null;
		}

		public RevocationDetailsBuilder SetSerialNumber(BigInteger serialNumber)
		{
			return null;
		}

		public RevocationDetailsBuilder SetSubject(X509Name subject)
		{
			return null;
		}

		public RevocationDetails Build()
		{
			return null;
		}
	}
}

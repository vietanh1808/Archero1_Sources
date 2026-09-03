using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	public class Req : X509ExtensionBase
	{
		private Request req;

		public X509Extensions SingleRequestExtensions => null;

		public Req(Request req)
		{
		}

		public CertificateID GetCertID()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}
	}
}

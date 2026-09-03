using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Ess
{
	[Obsolete("Use version in Asn1.Esf instead")]
	public class OtherSigningCertificate : Asn1Encodable
	{
		private Asn1Sequence certs;

		private Asn1Sequence policies;

		public static OtherSigningCertificate GetInstance(object o)
		{
			return null;
		}

		public OtherSigningCertificate(Asn1Sequence seq)
		{
		}

		public OtherSigningCertificate(OtherCertID otherCertID)
		{
		}

		public OtherCertID[] GetCerts()
		{
			return null;
		}

		public PolicyInformation[] GetPolicies()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

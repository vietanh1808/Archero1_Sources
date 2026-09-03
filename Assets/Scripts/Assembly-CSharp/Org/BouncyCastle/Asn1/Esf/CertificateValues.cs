using System.Collections;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Esf
{
	public class CertificateValues : Asn1Encodable
	{
		private readonly Asn1Sequence certificates;

		public static CertificateValues GetInstance(object obj)
		{
			return null;
		}

		private CertificateValues(Asn1Sequence seq)
		{
		}

		public CertificateValues(params X509CertificateStructure[] certificates)
		{
		}

		public CertificateValues(IEnumerable certificates)
		{
		}

		public X509CertificateStructure[] GetCertificates()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

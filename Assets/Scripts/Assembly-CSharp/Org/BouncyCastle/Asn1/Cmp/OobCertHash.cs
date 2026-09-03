using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cmp
{
	public class OobCertHash : Asn1Encodable
	{
		private readonly AlgorithmIdentifier hashAlg;

		private readonly CertId certId;

		private readonly DerBitString hashVal;

		public virtual AlgorithmIdentifier HashAlg => null;

		public virtual CertId CertID => null;

		private OobCertHash(Asn1Sequence seq)
		{
		}

		public static OobCertHash GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		private void AddOptional(Asn1EncodableVector v, int tagNo, Asn1Encodable obj)
		{
		}
	}
}

using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Ess;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Tsp
{
	public class TimeStampToken
	{
		private class CertID
		{
			private EssCertID certID;

			private EssCertIDv2 certIDv2;

			public IssuerSerial IssuerSerial => null;

			internal CertID(EssCertID certID)
			{
			}

			internal CertID(EssCertIDv2 certID)
			{
			}

			public string GetHashAlgorithmName()
			{
				return null;
			}

			public AlgorithmIdentifier GetHashAlgorithm()
			{
				return null;
			}

			public byte[] GetCertHash()
			{
				return null;
			}
		}

		private readonly CmsSignedData tsToken;

		private readonly SignerInformation tsaSignerInfo;

		private readonly TimeStampTokenInfo tstInfo;

		private readonly CertID certID;

		public TimeStampTokenInfo TimeStampInfo => null;

		public SignerID SignerID => null;

		public Org.BouncyCastle.Asn1.Cms.AttributeTable SignedAttributes => null;

		public Org.BouncyCastle.Asn1.Cms.AttributeTable UnsignedAttributes => null;

		public TimeStampToken(ContentInfo contentInfo)
		{
		}

		public TimeStampToken(CmsSignedData signedData)
		{
		}

		public IX509Store GetCertificates(string type)
		{
			return null;
		}

		public IX509Store GetCrls(string type)
		{
			return null;
		}

		public IX509Store GetAttributeCertificates(string type)
		{
			return null;
		}

		public void Validate(X509Certificate cert)
		{
		}

		public CmsSignedData ToCmsSignedData()
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}
	}
}

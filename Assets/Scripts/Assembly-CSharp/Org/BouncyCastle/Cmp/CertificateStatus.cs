using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	public class CertificateStatus
	{
		private static readonly DefaultSignatureAlgorithmIdentifierFinder sigAlgFinder;

		private readonly DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

		private readonly CertStatus certStatus;

		public PkiStatusInfo PkiStatusInfo => null;

		public BigInteger CertRequestId => null;

		public CertificateStatus(DefaultDigestAlgorithmIdentifierFinder digestAlgFinder, CertStatus certStatus)
		{
		}

		public bool IsVerified(X509Certificate cert)
		{
			return false;
		}
	}
}

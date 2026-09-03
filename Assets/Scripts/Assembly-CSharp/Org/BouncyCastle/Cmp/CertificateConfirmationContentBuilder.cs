using System.Collections;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	public class CertificateConfirmationContentBuilder
	{
		private static readonly DefaultSignatureAlgorithmIdentifierFinder sigAlgFinder;

		private readonly DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

		private readonly IList acceptedCerts;

		private readonly IList acceptedReqIds;

		public CertificateConfirmationContentBuilder()
		{
		}

		public CertificateConfirmationContentBuilder(DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
		{
		}

		public CertificateConfirmationContentBuilder AddAcceptedCertificate(X509Certificate certHolder, BigInteger certReqId)
		{
			return null;
		}

		public CertificateConfirmationContent Build()
		{
			return null;
		}
	}
}

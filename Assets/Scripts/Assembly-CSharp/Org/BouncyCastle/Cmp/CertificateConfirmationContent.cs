using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Cms;

namespace Org.BouncyCastle.Cmp
{
	public class CertificateConfirmationContent
	{
		private readonly DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

		private readonly CertConfirmContent content;

		public CertificateConfirmationContent(CertConfirmContent content)
		{
		}

		public CertificateConfirmationContent(CertConfirmContent content, DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
		{
		}

		public CertConfirmContent ToAsn1Structure()
		{
			return null;
		}

		public CertificateStatus[] GetStatusMessages()
		{
			return null;
		}
	}
}

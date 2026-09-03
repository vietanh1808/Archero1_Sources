using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Operators
{
	public class CmsKeyTransRecipientInfoGenerator : KeyTransRecipientInfoGenerator
	{
		private readonly IKeyWrapper keyWrapper;

		protected override AlgorithmIdentifier AlgorithmDetails => null;

		public CmsKeyTransRecipientInfoGenerator(X509Certificate recipCert, IKeyWrapper keyWrapper)
		{
		}

		public CmsKeyTransRecipientInfoGenerator(byte[] subjectKeyID, IKeyWrapper keyWrapper)
		{
		}

		protected override byte[] GenerateWrappedKey(KeyParameter contentKey)
		{
			return null;
		}
	}
}

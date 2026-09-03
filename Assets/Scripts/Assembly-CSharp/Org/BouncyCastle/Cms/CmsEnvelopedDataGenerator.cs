using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	public class CmsEnvelopedDataGenerator : CmsEnvelopedGenerator
	{
		public CmsEnvelopedDataGenerator()
		{
		}

		public CmsEnvelopedDataGenerator(SecureRandom rand)
		{
		}

		private CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid, CipherKeyGenerator keyGen)
		{
			return null;
		}

		public CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid)
		{
			return null;
		}

		public CmsEnvelopedData Generate(CmsProcessable content, ICipherBuilderWithKey cipherBuilder)
		{
			return null;
		}

		public CmsEnvelopedData Generate(CmsProcessable content, string encryptionOid, int keySize)
		{
			return null;
		}
	}
}

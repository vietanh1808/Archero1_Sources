using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	public class CmsAuthenticatedDataGenerator : CmsAuthenticatedGenerator
	{
		public CmsAuthenticatedDataGenerator()
		{
		}

		public CmsAuthenticatedDataGenerator(SecureRandom rand)
		{
		}

		private CmsAuthenticatedData Generate(CmsProcessable content, string macOid, CipherKeyGenerator keyGen)
		{
			return null;
		}

		public CmsAuthenticatedData Generate(CmsProcessable content, string encryptionOid)
		{
			return null;
		}
	}
}

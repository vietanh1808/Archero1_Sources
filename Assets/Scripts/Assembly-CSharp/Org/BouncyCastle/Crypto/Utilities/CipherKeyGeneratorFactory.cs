using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Utilities
{
	public class CipherKeyGeneratorFactory
	{
		private CipherKeyGeneratorFactory()
		{
		}

		public static CipherKeyGenerator CreateKeyGenerator(DerObjectIdentifier algorithm, SecureRandom random)
		{
			return null;
		}

		private static CipherKeyGenerator CreateCipherKeyGenerator(SecureRandom random, int keySize)
		{
			return null;
		}
	}
}

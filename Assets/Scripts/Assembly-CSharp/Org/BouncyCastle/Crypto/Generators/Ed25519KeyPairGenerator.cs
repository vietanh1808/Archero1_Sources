using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	public class Ed25519KeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		private SecureRandom random;

		public virtual void Init(KeyGenerationParameters parameters)
		{
		}

		public virtual AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}
	}
}

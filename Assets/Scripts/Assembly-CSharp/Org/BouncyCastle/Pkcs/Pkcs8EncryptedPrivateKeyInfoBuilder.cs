using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Pkcs
{
	public class Pkcs8EncryptedPrivateKeyInfoBuilder
	{
		private PrivateKeyInfo privateKeyInfo;

		public Pkcs8EncryptedPrivateKeyInfoBuilder(byte[] privateKeyInfo)
		{
		}

		public Pkcs8EncryptedPrivateKeyInfoBuilder(PrivateKeyInfo privateKeyInfo)
		{
		}

		public Pkcs8EncryptedPrivateKeyInfo Build(ICipherBuilder encryptor)
		{
			return null;
		}
	}
}

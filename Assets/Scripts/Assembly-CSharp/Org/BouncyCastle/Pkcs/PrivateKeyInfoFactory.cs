using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Pkcs
{
	public sealed class PrivateKeyInfoFactory
	{
		private PrivateKeyInfoFactory()
		{
		}

		public static PrivateKeyInfo CreatePrivateKeyInfo(AsymmetricKeyParameter privateKey)
		{
			return null;
		}

		public static PrivateKeyInfo CreatePrivateKeyInfo(AsymmetricKeyParameter privateKey, Asn1Set attributes)
		{
			return null;
		}

		public static PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, EncryptedPrivateKeyInfo encInfo)
		{
			return null;
		}

		public static PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, bool wrongPkcs12Zero, EncryptedPrivateKeyInfo encInfo)
		{
			return null;
		}

		private static void ExtractBytes(byte[] encKey, int size, int offSet, BigInteger bI)
		{
		}
	}
}

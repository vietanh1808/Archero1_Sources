using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Security
{
	public sealed class PrivateKeyFactory
	{
		private PrivateKeyFactory()
		{
		}

		public static AsymmetricKeyParameter CreateKey(byte[] privateKeyInfoData)
		{
			return null;
		}

		public static AsymmetricKeyParameter CreateKey(Stream inStr)
		{
			return null;
		}

		public static AsymmetricKeyParameter CreateKey(PrivateKeyInfo keyInfo)
		{
			return null;
		}

		private static byte[] GetRawKey(PrivateKeyInfo keyInfo, int expectedSize)
		{
			return null;
		}

		public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, EncryptedPrivateKeyInfo encInfo)
		{
			return null;
		}

		public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, byte[] encryptedPrivateKeyInfoData)
		{
			return null;
		}

		public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, Stream encryptedPrivateKeyInfoStream)
		{
			return null;
		}

		private static AsymmetricKeyParameter DecryptKey(char[] passPhrase, Asn1Object asn1Object)
		{
			return null;
		}

		public static byte[] EncryptKey(DerObjectIdentifier algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
		{
			return null;
		}

		public static byte[] EncryptKey(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
		{
			return null;
		}
	}
}

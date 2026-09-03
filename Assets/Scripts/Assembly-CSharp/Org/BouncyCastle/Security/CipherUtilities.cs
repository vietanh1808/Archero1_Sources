using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Security
{
	public sealed class CipherUtilities
	{
		private enum CipherAlgorithm
		{
			AES = 0,
			ARC4 = 1,
			BLOWFISH = 2,
			CAMELLIA = 3,
			CAST5 = 4,
			CAST6 = 5,
			DES = 6,
			DESEDE = 7,
			ELGAMAL = 8,
			GOST28147 = 9,
			HC128 = 10,
			HC256 = 11,
			IDEA = 12,
			NOEKEON = 13,
			PBEWITHSHAAND128BITRC4 = 14,
			PBEWITHSHAAND40BITRC4 = 15,
			RC2 = 16,
			RC5 = 17,
			RC5_64 = 18,
			RC6 = 19,
			RIJNDAEL = 20,
			RSA = 21,
			SALSA20 = 22,
			SEED = 23,
			SERPENT = 24,
			SKIPJACK = 25,
			SM4 = 26,
			TEA = 27,
			THREEFISH_256 = 28,
			THREEFISH_512 = 29,
			THREEFISH_1024 = 30,
			TNEPRES = 31,
			TWOFISH = 32,
			VMPC = 33,
			VMPC_KSA3 = 34,
			XTEA = 35
		}

		private enum CipherMode
		{
			ECB = 0,
			NONE = 1,
			CBC = 2,
			CCM = 3,
			CFB = 4,
			CTR = 5,
			CTS = 6,
			EAX = 7,
			GCM = 8,
			GOFB = 9,
			OCB = 10,
			OFB = 11,
			OPENPGPCFB = 12,
			SIC = 13
		}

		private enum CipherPadding
		{
			NOPADDING = 0,
			RAW = 1,
			ISO10126PADDING = 2,
			ISO10126D2PADDING = 3,
			ISO10126_2PADDING = 4,
			ISO7816_4PADDING = 5,
			ISO9797_1PADDING = 6,
			ISO9796_1 = 7,
			ISO9796_1PADDING = 8,
			OAEP = 9,
			OAEPPADDING = 10,
			OAEPWITHMD5ANDMGF1PADDING = 11,
			OAEPWITHSHA1ANDMGF1PADDING = 12,
			OAEPWITHSHA_1ANDMGF1PADDING = 13,
			OAEPWITHSHA224ANDMGF1PADDING = 14,
			OAEPWITHSHA_224ANDMGF1PADDING = 15,
			OAEPWITHSHA256ANDMGF1PADDING = 16,
			OAEPWITHSHA_256ANDMGF1PADDING = 17,
			OAEPWITHSHA384ANDMGF1PADDING = 18,
			OAEPWITHSHA_384ANDMGF1PADDING = 19,
			OAEPWITHSHA512ANDMGF1PADDING = 20,
			OAEPWITHSHA_512ANDMGF1PADDING = 21,
			PKCS1 = 22,
			PKCS1PADDING = 23,
			PKCS5 = 24,
			PKCS5PADDING = 25,
			PKCS7 = 26,
			PKCS7PADDING = 27,
			TBCPADDING = 28,
			WITHCTS = 29,
			X923PADDING = 30,
			ZEROBYTEPADDING = 31
		}

		private static readonly IDictionary algorithms;

		private static readonly IDictionary oids;

		public static ICollection Algorithms => null;

		static CipherUtilities()
		{
		}

		private CipherUtilities()
		{
		}

		public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			return null;
		}

		public static IBufferedCipher GetCipher(DerObjectIdentifier oid)
		{
			return null;
		}

		public static IBufferedCipher GetCipher(string algorithm)
		{
			return null;
		}

		public static string GetAlgorithmName(DerObjectIdentifier oid)
		{
			return null;
		}

		private static int GetDigitIndex(string s)
		{
			return 0;
		}

		private static IBlockCipher CreateBlockCipher(CipherAlgorithm cipherAlgorithm)
		{
			return null;
		}
	}
}

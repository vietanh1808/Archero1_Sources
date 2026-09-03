using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public sealed class Rfc6637Utilities
	{
		private static readonly byte[] ANONYMOUS_SENDER;

		private Rfc6637Utilities()
		{
		}

		public static string GetAgreementAlgorithm(PublicKeyPacket pubKeyData)
		{
			return null;
		}

		public static DerObjectIdentifier GetKeyEncryptionOID(SymmetricKeyAlgorithmTag algID)
		{
			return null;
		}

		public static int GetKeyLength(SymmetricKeyAlgorithmTag algID)
		{
			return 0;
		}

		public static byte[] CreateKey(PublicKeyPacket pubKeyData, ECPoint s)
		{
			return null;
		}

		public static byte[] CreateUserKeyingMaterial(PublicKeyPacket pubKeyData)
		{
			return null;
		}

		private static byte[] Kdf(HashAlgorithmTag digestAlg, ECPoint s, int keyLen, byte[] parameters)
		{
			return null;
		}
	}
}

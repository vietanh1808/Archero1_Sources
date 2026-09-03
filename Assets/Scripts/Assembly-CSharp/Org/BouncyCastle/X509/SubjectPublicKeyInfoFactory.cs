using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.X509
{
	public sealed class SubjectPublicKeyInfoFactory
	{
		private SubjectPublicKeyInfoFactory()
		{
		}

		public static SubjectPublicKeyInfo CreateSubjectPublicKeyInfo(AsymmetricKeyParameter publicKey)
		{
			return null;
		}

		private static void ExtractBytes(byte[] encKey, int offset, BigInteger bI)
		{
		}

		private static void ExtractBytes(byte[] encKey, int size, int offSet, BigInteger bI)
		{
		}
	}
}

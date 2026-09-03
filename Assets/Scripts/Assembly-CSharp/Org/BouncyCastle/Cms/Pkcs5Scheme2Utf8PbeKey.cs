using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms
{
	public class Pkcs5Scheme2Utf8PbeKey : CmsPbeKey
	{
		[Obsolete("Use version taking 'char[]' instead")]
		public Pkcs5Scheme2Utf8PbeKey(string password, byte[] salt, int iterationCount)
			: base((string)null, (byte[])null, 0)
		{
		}

		[Obsolete("Use version taking 'char[]' instead")]
		public Pkcs5Scheme2Utf8PbeKey(string password, AlgorithmIdentifier keyDerivationAlgorithm)
			: base((string)null, (byte[])null, 0)
		{
		}

		public Pkcs5Scheme2Utf8PbeKey(char[] password, byte[] salt, int iterationCount)
			: base((string)null, (byte[])null, 0)
		{
		}

		public Pkcs5Scheme2Utf8PbeKey(char[] password, AlgorithmIdentifier keyDerivationAlgorithm)
			: base((string)null, (byte[])null, 0)
		{
		}

		internal override KeyParameter GetEncoded(string algorithmOid)
		{
			return null;
		}
	}
}

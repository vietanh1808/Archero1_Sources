using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms
{
	public abstract class CmsPbeKey : ICipherParameters
	{
		internal readonly char[] password;

		internal readonly byte[] salt;

		internal readonly int iterationCount;

		[Obsolete("Will be removed")]
		public string Password => null;

		public byte[] Salt => null;

		public int IterationCount => 0;

		public string Algorithm => null;

		public string Format => null;

		[Obsolete("Use version taking 'char[]' instead")]
		public CmsPbeKey(string password, byte[] salt, int iterationCount)
		{
		}

		[Obsolete("Use version taking 'char[]' instead")]
		public CmsPbeKey(string password, AlgorithmIdentifier keyDerivationAlgorithm)
		{
		}

		public CmsPbeKey(char[] password, byte[] salt, int iterationCount)
		{
		}

		public CmsPbeKey(char[] password, AlgorithmIdentifier keyDerivationAlgorithm)
		{
		}

		~CmsPbeKey()
		{
		}

		[Obsolete("Use 'Salt' property instead")]
		public byte[] GetSalt()
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		internal abstract KeyParameter GetEncoded(string algorithmOid);
	}
}

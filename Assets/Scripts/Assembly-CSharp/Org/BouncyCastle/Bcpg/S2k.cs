using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class S2k : BcpgObject
	{
		private const int ExpBias = 6;

		public const int Simple = 0;

		public const int Salted = 1;

		public const int SaltedAndIterated = 3;

		public const int GnuDummyS2K = 101;

		public const int GnuProtectionModeNoPrivateKey = 1;

		public const int GnuProtectionModeDivertToCard = 2;

		internal int type;

		internal HashAlgorithmTag algorithm;

		internal byte[] iv;

		internal int itCount;

		internal int protectionMode;

		public virtual int Type => 0;

		public virtual HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

		public virtual long IterationCount => 0L;

		public virtual int ProtectionMode => 0;

		internal S2k(Stream inStr)
		{
		}

		public S2k(HashAlgorithmTag algorithm)
		{
		}

		public S2k(HashAlgorithmTag algorithm, byte[] iv)
		{
		}

		public S2k(HashAlgorithmTag algorithm, byte[] iv, int itCount)
		{
		}

		public virtual byte[] GetIV()
		{
			return null;
		}

		[Obsolete("Use 'IterationCount' property instead")]
		public long GetIterationCount()
		{
			return 0L;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Engines
{
	public class NaccacheSternEngine : IAsymmetricBlockCipher
	{
		private bool forEncryption;

		private NaccacheSternKeyParameters key;

		private IList[] lookup;

		public string AlgorithmName => null;

		[Obsolete("Remove: no longer used")]
		public virtual bool Debug
		{
			set
			{
			}
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int GetInputBlockSize()
		{
			return 0;
		}

		public virtual int GetOutputBlockSize()
		{
			return 0;
		}

		public virtual byte[] ProcessBlock(byte[] inBytes, int inOff, int length)
		{
			return null;
		}

		public virtual byte[] Encrypt(BigInteger plain)
		{
			return null;
		}

		public virtual byte[] AddCryptedBlocks(byte[] block1, byte[] block2)
		{
			return null;
		}

		public virtual byte[] ProcessData(byte[] data)
		{
			return null;
		}

		private static BigInteger chineseRemainder(IList congruences, IList primes)
		{
			return null;
		}
	}
}

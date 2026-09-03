using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Habby.AssetExpress.Network.Crypto
{
	public class CounterModeCryptoTransform : ICryptoTransform, IDisposable
	{
		private readonly byte[] _counter;

		private readonly ICryptoTransform _counterEncryptor;

		private readonly Queue<byte> _xorMask;

		private readonly SymmetricAlgorithm _symmetricAlgorithm;

		public int InputBlockSize => 0;

		public int OutputBlockSize => 0;

		public bool CanTransformMultipleBlocks => false;

		public bool CanReuseTransform => false;

		public CounterModeCryptoTransform(SymmetricAlgorithm symmetricAlgorithm, byte[] key, byte[] counter)
		{
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		private bool NeedMoreXorMaskBytes()
		{
			return false;
		}

		private void EncryptCounterThenIncrement()
		{
		}

		private void IncrementCounter()
		{
		}

		public void Dispose()
		{
		}
	}
}

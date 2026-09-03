using System.Security.Cryptography;

namespace Habby.Archero.Crypto
{
	public class Aes128CounterMode : SymmetricAlgorithm
	{
		private readonly byte[] _counter;

		private readonly AesManaged _aes;

		public Aes128CounterMode(byte[] counter)
		{
		}

		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] ignoredParameter)
		{
			return null;
		}

		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] ignoredParameter)
		{
			return null;
		}

		public override void GenerateKey()
		{
		}

		public override void GenerateIV()
		{
		}
	}
}

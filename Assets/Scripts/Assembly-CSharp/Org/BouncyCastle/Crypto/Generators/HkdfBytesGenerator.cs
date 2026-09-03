using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	public class HkdfBytesGenerator : IDerivationFunction
	{
		private HMac hMacHash;

		private int hashLen;

		private byte[] info;

		private byte[] currentT;

		private int generatedBytes;

		public virtual IDigest Digest => null;

		public HkdfBytesGenerator(IDigest hash)
		{
		}

		public virtual void Init(IDerivationParameters parameters)
		{
		}

		private KeyParameter Extract(byte[] salt, byte[] ikm)
		{
			return null;
		}

		private void ExpandNext()
		{
		}

		public virtual int GenerateBytes(byte[] output, int outOff, int len)
		{
			return 0;
		}
	}
}

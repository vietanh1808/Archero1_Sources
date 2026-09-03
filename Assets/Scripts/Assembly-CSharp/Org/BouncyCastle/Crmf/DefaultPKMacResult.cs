using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crmf
{
	internal class DefaultPKMacResult : IBlockResult
	{
		private readonly IMac mac;

		public DefaultPKMacResult(IMac mac)
		{
		}

		public byte[] Collect()
		{
			return null;
		}

		public int Collect(byte[] sig, int sigOff)
		{
			return 0;
		}
	}
}

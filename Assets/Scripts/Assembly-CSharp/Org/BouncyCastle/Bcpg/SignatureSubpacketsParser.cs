using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class SignatureSubpacketsParser
	{
		private readonly Stream input;

		public SignatureSubpacketsParser(Stream input)
		{
		}

		public SignatureSubpacket ReadPacket()
		{
			return null;
		}

		private byte[] CheckData(byte[] data, int expected, int bytesRead, string name)
		{
			return null;
		}
	}
}

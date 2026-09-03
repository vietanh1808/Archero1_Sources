using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpCompressedData : PgpObject
	{
		private readonly CompressedDataPacket data;

		public CompressionAlgorithmTag Algorithm => CompressionAlgorithmTag.Uncompressed;

		public PgpCompressedData(BcpgInputStream bcpgInput)
		{
		}

		public Stream GetInputStream()
		{
			return null;
		}

		public Stream GetDataStream()
		{
			return null;
		}
	}
}

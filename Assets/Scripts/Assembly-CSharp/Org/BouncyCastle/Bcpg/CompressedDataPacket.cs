namespace Org.BouncyCastle.Bcpg
{
	public class CompressedDataPacket : InputStreamPacket
	{
		private readonly CompressionAlgorithmTag algorithm;

		public CompressionAlgorithmTag Algorithm => CompressionAlgorithmTag.Uncompressed;

		internal CompressedDataPacket(BcpgInputStream bcpgIn)
			: base(null)
		{
		}
	}
}

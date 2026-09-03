namespace Org.BouncyCastle.Bcpg
{
	public class LiteralDataPacket : InputStreamPacket
	{
		private int format;

		private byte[] fileName;

		private long modDate;

		public int Format => 0;

		public long ModificationTime => 0L;

		public string FileName => null;

		internal LiteralDataPacket(BcpgInputStream bcpgIn)
			: base(null)
		{
		}

		public byte[] GetRawFileName()
		{
			return null;
		}
	}
}

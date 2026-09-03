namespace Org.BouncyCastle.Bcpg
{
	public class ExperimentalPacket : ContainedPacket
	{
		private readonly PacketTag tag;

		private readonly byte[] contents;

		public PacketTag Tag => PacketTag.Reserved;

		internal ExperimentalPacket(PacketTag tag, BcpgInputStream bcpgIn)
		{
		}

		public byte[] GetContents()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

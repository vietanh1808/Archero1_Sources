namespace Org.BouncyCastle.Bcpg
{
	public abstract class ContainedPacket : Packet
	{
		public byte[] GetEncoded()
		{
			return null;
		}

		public abstract void Encode(BcpgOutputStream bcpgOut);
	}
}

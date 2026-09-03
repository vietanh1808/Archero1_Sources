namespace Org.BouncyCastle.Bcpg
{
	public class UserAttributePacket : ContainedPacket
	{
		private readonly UserAttributeSubpacket[] subpackets;

		public UserAttributePacket(BcpgInputStream bcpgIn)
		{
		}

		public UserAttributePacket(UserAttributeSubpacket[] subpackets)
		{
		}

		public UserAttributeSubpacket[] GetSubpackets()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

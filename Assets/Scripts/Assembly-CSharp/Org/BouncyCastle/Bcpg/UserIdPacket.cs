namespace Org.BouncyCastle.Bcpg
{
	public class UserIdPacket : ContainedPacket
	{
		private readonly byte[] idData;

		public UserIdPacket(BcpgInputStream bcpgIn)
		{
		}

		public UserIdPacket(string id)
		{
		}

		public string GetId()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

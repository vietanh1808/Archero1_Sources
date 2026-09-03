namespace Org.BouncyCastle.Bcpg
{
	public class TrustPacket : ContainedPacket
	{
		private readonly byte[] levelAndTrustAmount;

		public TrustPacket(BcpgInputStream bcpgIn)
		{
		}

		public TrustPacket(int trustCode)
		{
		}

		public byte[] GetLevelAndTrustAmount()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

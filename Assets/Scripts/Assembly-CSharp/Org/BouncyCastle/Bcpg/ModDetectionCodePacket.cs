namespace Org.BouncyCastle.Bcpg
{
	public class ModDetectionCodePacket : ContainedPacket
	{
		private readonly byte[] digest;

		internal ModDetectionCodePacket(BcpgInputStream bcpgIn)
		{
		}

		public ModDetectionCodePacket(byte[] digest)
		{
		}

		public byte[] GetDigest()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

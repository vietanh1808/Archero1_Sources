namespace Org.BouncyCastle.Bcpg
{
	public class PublicKeyEncSessionPacket : ContainedPacket
	{
		private int version;

		private long keyId;

		private PublicKeyAlgorithmTag algorithm;

		private byte[][] data;

		public int Version => 0;

		public long KeyId => 0L;

		public PublicKeyAlgorithmTag Algorithm => (PublicKeyAlgorithmTag)0;

		internal PublicKeyEncSessionPacket(BcpgInputStream bcpgIn)
		{
		}

		public PublicKeyEncSessionPacket(long keyId, PublicKeyAlgorithmTag algorithm, byte[][] data)
		{
		}

		public byte[][] GetEncSessionKey()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

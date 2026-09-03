namespace Org.BouncyCastle.Bcpg
{
	public class SecretKeyPacket : ContainedPacket
	{
		public const int UsageNone = 0;

		public const int UsageChecksum = 255;

		public const int UsageSha1 = 254;

		private PublicKeyPacket pubKeyPacket;

		private readonly byte[] secKeyData;

		private int s2kUsage;

		private SymmetricKeyAlgorithmTag encAlgorithm;

		private S2k s2k;

		private byte[] iv;

		public SymmetricKeyAlgorithmTag EncAlgorithm => SymmetricKeyAlgorithmTag.Null;

		public int S2kUsage => 0;

		public S2k S2k => null;

		public PublicKeyPacket PublicKeyPacket => null;

		internal SecretKeyPacket(BcpgInputStream bcpgIn)
		{
		}

		public SecretKeyPacket(PublicKeyPacket pubKeyPacket, SymmetricKeyAlgorithmTag encAlgorithm, S2k s2k, byte[] iv, byte[] secKeyData)
		{
		}

		public SecretKeyPacket(PublicKeyPacket pubKeyPacket, SymmetricKeyAlgorithmTag encAlgorithm, int s2kUsage, S2k s2k, byte[] iv, byte[] secKeyData)
		{
		}

		public byte[] GetIV()
		{
			return null;
		}

		public byte[] GetSecretKeyData()
		{
			return null;
		}

		public byte[] GetEncodedContents()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

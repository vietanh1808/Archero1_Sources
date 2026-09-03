namespace Org.BouncyCastle.Bcpg
{
	public class SymmetricKeyEncSessionPacket : ContainedPacket
	{
		private int version;

		private SymmetricKeyAlgorithmTag encAlgorithm;

		private S2k s2k;

		private readonly byte[] secKeyData;

		public SymmetricKeyAlgorithmTag EncAlgorithm => SymmetricKeyAlgorithmTag.Null;

		public S2k S2k => null;

		public int Version => 0;

		public SymmetricKeyEncSessionPacket(BcpgInputStream bcpgIn)
		{
		}

		public SymmetricKeyEncSessionPacket(SymmetricKeyAlgorithmTag encAlgorithm, S2k s2k, byte[] secKeyData)
		{
		}

		public byte[] GetSecKeyData()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

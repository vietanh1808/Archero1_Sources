namespace Org.BouncyCastle.Bcpg
{
	public class SecretSubkeyPacket : SecretKeyPacket
	{
		internal SecretSubkeyPacket(BcpgInputStream bcpgIn)
			: base(null)
		{
		}

		public SecretSubkeyPacket(PublicKeyPacket pubKeyPacket, SymmetricKeyAlgorithmTag encAlgorithm, S2k s2k, byte[] iv, byte[] secKeyData)
			: base(null)
		{
		}

		public SecretSubkeyPacket(PublicKeyPacket pubKeyPacket, SymmetricKeyAlgorithmTag encAlgorithm, int s2kUsage, S2k s2k, byte[] iv, byte[] secKeyData)
			: base(null)
		{
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

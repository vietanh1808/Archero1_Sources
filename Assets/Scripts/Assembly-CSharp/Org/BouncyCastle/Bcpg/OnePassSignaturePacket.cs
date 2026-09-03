namespace Org.BouncyCastle.Bcpg
{
	public class OnePassSignaturePacket : ContainedPacket
	{
		private int version;

		private int sigType;

		private HashAlgorithmTag hashAlgorithm;

		private PublicKeyAlgorithmTag keyAlgorithm;

		private long keyId;

		private int nested;

		public int SignatureType => 0;

		public PublicKeyAlgorithmTag KeyAlgorithm => (PublicKeyAlgorithmTag)0;

		public HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

		public long KeyId => 0L;

		internal OnePassSignaturePacket(BcpgInputStream bcpgIn)
		{
		}

		public OnePassSignaturePacket(int sigType, HashAlgorithmTag hashAlgorithm, PublicKeyAlgorithmTag keyAlgorithm, long keyId, bool isNested)
		{
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

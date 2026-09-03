namespace Org.BouncyCastle.Bcpg
{
	public class SignaturePacket : ContainedPacket
	{
		private int version;

		private int signatureType;

		private long creationTime;

		private long keyId;

		private PublicKeyAlgorithmTag keyAlgorithm;

		private HashAlgorithmTag hashAlgorithm;

		private MPInteger[] signature;

		private byte[] fingerprint;

		private SignatureSubpacket[] hashedData;

		private SignatureSubpacket[] unhashedData;

		private byte[] signatureEncoding;

		public int Version => 0;

		public int SignatureType => 0;

		public long KeyId => 0L;

		public PublicKeyAlgorithmTag KeyAlgorithm => (PublicKeyAlgorithmTag)0;

		public HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

		public long CreationTime => 0L;

		internal SignaturePacket(BcpgInputStream bcpgIn)
		{
		}

		public SignaturePacket(int signatureType, long keyId, PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm, SignatureSubpacket[] hashedData, SignatureSubpacket[] unhashedData, byte[] fingerprint, MPInteger[] signature)
		{
		}

		public SignaturePacket(int version, int signatureType, long keyId, PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm, long creationTime, byte[] fingerprint, MPInteger[] signature)
		{
		}

		public SignaturePacket(int version, int signatureType, long keyId, PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm, SignatureSubpacket[] hashedData, SignatureSubpacket[] unhashedData, byte[] fingerprint, MPInteger[] signature)
		{
		}

		public byte[] GetSignatureTrailer()
		{
			return null;
		}

		public MPInteger[] GetSignature()
		{
			return null;
		}

		public byte[] GetSignatureBytes()
		{
			return null;
		}

		public SignatureSubpacket[] GetHashedSubPackets()
		{
			return null;
		}

		public SignatureSubpacket[] GetUnhashedSubPackets()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}

		private static void EncodeLengthAndData(BcpgOutputStream pOut, byte[] data)
		{
		}

		private static byte[] GetEncodedSubpackets(SignatureSubpacket[] ps)
		{
			return null;
		}

		private void setCreationTime()
		{
		}
	}
}

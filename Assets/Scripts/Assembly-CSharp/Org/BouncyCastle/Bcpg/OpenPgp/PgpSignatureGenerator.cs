using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSignatureGenerator
	{
		private static readonly SignatureSubpacket[] EmptySignatureSubpackets;

		private PublicKeyAlgorithmTag keyAlgorithm;

		private HashAlgorithmTag hashAlgorithm;

		private PgpPrivateKey privKey;

		private ISigner sig;

		private IDigest dig;

		private int signatureType;

		private byte lastb;

		private SignatureSubpacket[] unhashed;

		private SignatureSubpacket[] hashed;

		public PgpSignatureGenerator(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
		{
		}

		public void InitSign(int sigType, PgpPrivateKey key)
		{
		}

		public void InitSign(int sigType, PgpPrivateKey key, SecureRandom random)
		{
		}

		public void Update(byte b)
		{
		}

		private void doCanonicalUpdateByte(byte b)
		{
		}

		private void doUpdateCRLF()
		{
		}

		private void doUpdateByte(byte b)
		{
		}

		public void Update(params byte[] b)
		{
		}

		public void Update(byte[] b, int off, int len)
		{
		}

		public void SetHashedSubpackets(PgpSignatureSubpacketVector hashedPackets)
		{
		}

		public void SetUnhashedSubpackets(PgpSignatureSubpacketVector unhashedPackets)
		{
		}

		public PgpOnePassSignature GenerateOnePassVersion(bool isNested)
		{
			return null;
		}

		public PgpSignature Generate()
		{
			return null;
		}

		public PgpSignature GenerateCertification(string id, PgpPublicKey pubKey)
		{
			return null;
		}

		public PgpSignature GenerateCertification(PgpUserAttributeSubpacketVector userAttributes, PgpPublicKey pubKey)
		{
			return null;
		}

		public PgpSignature GenerateCertification(PgpPublicKey masterKey, PgpPublicKey pubKey)
		{
			return null;
		}

		public PgpSignature GenerateCertification(PgpPublicKey pubKey)
		{
			return null;
		}

		private byte[] GetEncodedPublicKey(PgpPublicKey pubKey)
		{
			return null;
		}

		private bool packetPresent(SignatureSubpacket[] packets, SignatureSubpacketTag type)
		{
			return false;
		}

		private SignatureSubpacket[] insertSubpacket(SignatureSubpacket[] packets, SignatureSubpacket subpacket)
		{
			return null;
		}

		private void UpdateWithIdData(int header, byte[] idBytes)
		{
		}

		private void UpdateWithPublicKey(PgpPublicKey key)
		{
		}
	}
}

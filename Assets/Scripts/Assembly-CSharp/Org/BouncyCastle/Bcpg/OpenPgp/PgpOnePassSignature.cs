using System.IO;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpOnePassSignature
	{
		private OnePassSignaturePacket sigPack;

		private int signatureType;

		private ISigner sig;

		private byte lastb;

		public long KeyId => 0L;

		public int SignatureType => 0;

		public HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

		public PublicKeyAlgorithmTag KeyAlgorithm => (PublicKeyAlgorithmTag)0;

		internal PgpOnePassSignature(BcpgInputStream bcpgInput)
		{
		}

		internal PgpOnePassSignature(OnePassSignaturePacket sigPack)
		{
		}

		public void InitVerify(PgpPublicKey pubKey)
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

		public void Update(byte[] bytes)
		{
		}

		public void Update(byte[] bytes, int off, int length)
		{
		}

		public bool Verify(PgpSignature pgpSig)
		{
			return false;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public void Encode(Stream outStr)
		{
		}
	}
}

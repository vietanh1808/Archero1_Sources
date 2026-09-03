using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpV3SignatureGenerator
	{
		private PublicKeyAlgorithmTag keyAlgorithm;

		private HashAlgorithmTag hashAlgorithm;

		private PgpPrivateKey privKey;

		private ISigner sig;

		private IDigest dig;

		private int signatureType;

		private byte lastb;

		public PgpV3SignatureGenerator(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
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

		public void Update(byte[] b)
		{
		}

		public void Update(byte[] b, int off, int len)
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
	}
}

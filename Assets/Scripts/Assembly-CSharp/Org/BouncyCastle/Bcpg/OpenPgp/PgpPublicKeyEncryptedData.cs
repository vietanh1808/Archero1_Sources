using System.IO;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpPublicKeyEncryptedData : PgpEncryptedData
	{
		private PublicKeyEncSessionPacket keyData;

		public long KeyId => 0L;

		internal PgpPublicKeyEncryptedData(PublicKeyEncSessionPacket keyData, InputStreamPacket encData)
			: base(null)
		{
		}

		private static IBufferedCipher GetKeyCipher(PublicKeyAlgorithmTag algorithm)
		{
			return null;
		}

		private bool ConfirmCheckSum(byte[] sessionInfo)
		{
			return false;
		}

		public SymmetricKeyAlgorithmTag GetSymmetricAlgorithm(PgpPrivateKey privKey)
		{
			return SymmetricKeyAlgorithmTag.Null;
		}

		public Stream GetDataStream(PgpPrivateKey privKey)
		{
			return null;
		}

		private byte[] RecoverSessionData(PgpPrivateKey privKey)
		{
			return null;
		}

		private static void ProcessEncodedMpi(IBufferedCipher cipher, int size, byte[] mpiEnc)
		{
		}
	}
}

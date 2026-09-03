using System.IO;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpPbeEncryptedData : PgpEncryptedData
	{
		private readonly SymmetricKeyEncSessionPacket keyData;

		internal PgpPbeEncryptedData(SymmetricKeyEncSessionPacket keyData, InputStreamPacket encData)
			: base(null)
		{
		}

		public override Stream GetInputStream()
		{
			return null;
		}

		public Stream GetDataStream(char[] passPhrase)
		{
			return null;
		}

		public Stream GetDataStreamUtf8(char[] passPhrase)
		{
			return null;
		}

		public Stream GetDataStreamRaw(byte[] rawPassPhrase)
		{
			return null;
		}

		internal Stream DoGetDataStream(byte[] rawPassPhrase, bool clearPassPhrase)
		{
			return null;
		}

		private IBufferedCipher CreateStreamCipher(SymmetricKeyAlgorithmTag keyAlgorithm)
		{
			return null;
		}
	}
}

using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public abstract class PgpEncryptedData
	{
		internal class TruncatedStream : BaseInputStream
		{
			private const int LookAheadSize = 22;

			private const int LookAheadBufSize = 512;

			private const int LookAheadBufLimit = 490;

			private readonly Stream inStr;

			private readonly byte[] lookAhead;

			private int bufStart;

			private int bufEnd;

			internal TruncatedStream(Stream inStr)
			{
			}

			private int FillBuffer()
			{
				return 0;
			}

			public override int ReadByte()
			{
				return 0;
			}

			public override int Read(byte[] buf, int off, int len)
			{
				return 0;
			}

			internal byte[] GetLookAhead()
			{
				return null;
			}
		}

		internal InputStreamPacket encData;

		internal Stream encStream;

		internal TruncatedStream truncStream;

		internal PgpEncryptedData(InputStreamPacket encData)
		{
		}

		public virtual Stream GetInputStream()
		{
			return null;
		}

		public bool IsIntegrityProtected()
		{
			return false;
		}

		public bool Verify()
		{
			return false;
		}
	}
}

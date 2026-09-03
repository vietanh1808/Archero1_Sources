using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	internal class RecordStream
	{
		private class HandshakeHashUpdateStream : BaseOutputStream
		{
			private readonly RecordStream mOuter;

			public HandshakeHashUpdateStream(RecordStream mOuter)
			{
			}

			public override void Write(byte[] buf, int off, int len)
			{
			}
		}

		private class SequenceNumber
		{
			private long value;

			private bool exhausted;

			internal long NextValue(byte alertDescription)
			{
				return 0L;
			}
		}

		private const int DEFAULT_PLAINTEXT_LIMIT = 16384;

		internal const int TLS_HEADER_SIZE = 5;

		internal const int TLS_HEADER_TYPE_OFFSET = 0;

		internal const int TLS_HEADER_VERSION_OFFSET = 1;

		internal const int TLS_HEADER_LENGTH_OFFSET = 3;

		private TlsProtocol mHandler;

		private Stream mInput;

		private Stream mOutput;

		private TlsCompression mPendingCompression;

		private TlsCompression mReadCompression;

		private TlsCompression mWriteCompression;

		private TlsCipher mPendingCipher;

		private TlsCipher mReadCipher;

		private TlsCipher mWriteCipher;

		private SequenceNumber mReadSeqNo;

		private SequenceNumber mWriteSeqNo;

		private MemoryStream mBuffer;

		private TlsHandshakeHash mHandshakeHash;

		private readonly BaseOutputStream mHandshakeHashUpdater;

		private ProtocolVersion mReadVersion;

		private ProtocolVersion mWriteVersion;

		private bool mRestrictReadVersion;

		private int mPlaintextLimit;

		private int mCompressedLimit;

		private int mCiphertextLimit;

		internal virtual ProtocolVersion ReadVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal virtual TlsHandshakeHash HandshakeHash => null;

		internal virtual Stream HandshakeHashUpdater => null;

		internal RecordStream(TlsProtocol handler, Stream input, Stream output)
		{
		}

		internal virtual void Init(TlsContext context)
		{
		}

		internal virtual int GetPlaintextLimit()
		{
			return 0;
		}

		internal virtual void SetPlaintextLimit(int plaintextLimit)
		{
		}

		internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
		{
		}

		internal virtual void SetRestrictReadVersion(bool enabled)
		{
		}

		internal virtual void SetPendingConnectionState(TlsCompression tlsCompression, TlsCipher tlsCipher)
		{
		}

		internal virtual void SentWriteCipherSpec()
		{
		}

		internal virtual void ReceivedReadCipherSpec()
		{
		}

		internal virtual void FinaliseHandshake()
		{
		}

		internal virtual void CheckRecordHeader(byte[] recordHeader)
		{
		}

		internal virtual bool ReadRecord()
		{
			return false;
		}

		internal virtual byte[] DecodeAndVerify(byte type, Stream input, int len)
		{
			return null;
		}

		internal virtual void WriteRecord(byte type, byte[] plaintext, int plaintextOffset, int plaintextLength)
		{
		}

		internal virtual void NotifyHelloComplete()
		{
		}

		internal virtual TlsHandshakeHash PrepareToFinish()
		{
			return null;
		}

		internal virtual void SafeClose()
		{
		}

		internal virtual void Flush()
		{
		}

		private byte[] GetBufferContents()
		{
			return null;
		}

		private static void CheckType(byte type, byte alertDescription)
		{
		}

		private static void CheckLength(int length, int limit, byte alertDescription)
		{
		}
	}
}

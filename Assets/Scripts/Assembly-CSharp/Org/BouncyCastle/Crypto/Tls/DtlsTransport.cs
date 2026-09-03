namespace Org.BouncyCastle.Crypto.Tls
{
	public class DtlsTransport : DatagramTransport
	{
		private readonly DtlsRecordLayer mRecordLayer;

		internal DtlsTransport(DtlsRecordLayer recordLayer)
		{
		}

		public virtual int GetReceiveLimit()
		{
			return 0;
		}

		public virtual int GetSendLimit()
		{
			return 0;
		}

		public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
		{
			return 0;
		}

		public virtual void Send(byte[] buf, int off, int len)
		{
		}

		public virtual void Close()
		{
		}
	}
}

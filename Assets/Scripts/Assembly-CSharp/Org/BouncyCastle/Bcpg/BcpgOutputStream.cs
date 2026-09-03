using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class BcpgOutputStream : BaseOutputStream
	{
		private Stream outStr;

		private byte[] partialBuffer;

		private int partialBufferLength;

		private int partialPower;

		private int partialOffset;

		private const int BufferSizePower = 16;

		internal static BcpgOutputStream Wrap(Stream outStr)
		{
			return null;
		}

		public BcpgOutputStream(Stream outStr)
		{
		}

		public BcpgOutputStream(Stream outStr, PacketTag tag)
		{
		}

		public BcpgOutputStream(Stream outStr, PacketTag tag, long length, bool oldFormat)
		{
		}

		public BcpgOutputStream(Stream outStr, PacketTag tag, long length)
		{
		}

		public BcpgOutputStream(Stream outStr, PacketTag tag, byte[] buffer)
		{
		}

		private void WriteNewPacketLength(long bodyLen)
		{
		}

		private void WriteHeader(PacketTag tag, bool oldPackets, bool partial, long bodyLen)
		{
		}

		private void PartialFlush(bool isLast)
		{
		}

		private void WritePartial(byte b)
		{
		}

		private void WritePartial(byte[] buffer, int off, int len)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		internal virtual void WriteShort(short n)
		{
		}

		internal virtual void WriteInt(int n)
		{
		}

		internal virtual void WriteLong(long n)
		{
		}

		public void WritePacket(ContainedPacket p)
		{
		}

		internal void WritePacket(PacketTag tag, byte[] body, bool oldFormat)
		{
		}

		public void WriteObject(BcpgObject bcpgObject)
		{
		}

		public void WriteObjects(params BcpgObject[] v)
		{
		}

		public override void Flush()
		{
		}

		public void Finish()
		{
		}

		public override void Close()
		{
		}
	}
}

using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class BcpgInputStream : BaseInputStream
	{
		private class PartialInputStream : BaseInputStream
		{
			private BcpgInputStream m_in;

			private bool partial;

			private int dataLength;

			internal PartialInputStream(BcpgInputStream bcpgIn, bool partial, int dataLength)
			{
			}

			public override int ReadByte()
			{
				return 0;
			}

			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			private int ReadPartialDataLength()
			{
				return 0;
			}
		}

		private Stream m_in;

		private bool next;

		private int nextB;

		internal static BcpgInputStream Wrap(Stream inStr)
		{
			return null;
		}

		private BcpgInputStream(Stream inputStream)
		{
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public byte[] ReadAll()
		{
			return null;
		}

		public void ReadFully(byte[] buffer, int off, int len)
		{
		}

		public void ReadFully(byte[] buffer)
		{
		}

		public PacketTag NextPacketTag()
		{
			return PacketTag.Reserved;
		}

		public Packet ReadPacket()
		{
			return null;
		}

		public override void Close()
		{
		}
	}
}

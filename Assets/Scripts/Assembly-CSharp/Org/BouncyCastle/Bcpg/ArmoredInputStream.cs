using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class ArmoredInputStream : BaseInputStream
	{
		private static readonly byte[] decodingTable;

		private Stream input;

		private bool start;

		private int[] outBuf;

		private int bufPtr;

		private Crc24 crc;

		private bool crcFound;

		private bool hasHeaders;

		private string header;

		private bool newLineFound;

		private bool clearText;

		private bool restart;

		private IList headerList;

		private int lastC;

		private bool isEndOfStream;

		static ArmoredInputStream()
		{
		}

		private int Decode(int in0, int in1, int in2, int in3, int[] result)
		{
			return 0;
		}

		public ArmoredInputStream(Stream input)
		{
		}

		public ArmoredInputStream(Stream input, bool hasHeaders)
		{
		}

		private bool ParseHeaders()
		{
			return false;
		}

		public bool IsClearText()
		{
			return false;
		}

		public bool IsEndOfStream()
		{
			return false;
		}

		public string GetArmorHeaderLine()
		{
			return null;
		}

		public string[] GetArmorHeaders()
		{
			return null;
		}

		private int ReadIgnoreSpace()
		{
			return 0;
		}

		private int ReadIgnoreWhitespace()
		{
			return 0;
		}

		private int ReadByteClearText()
		{
			return 0;
		}

		private int ReadClearText(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		private int DoReadByte()
		{
			return 0;
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override void Close()
		{
		}
	}
}

using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class ArmoredOutputStream : BaseOutputStream
	{
		public static readonly string HeaderVersion;

		private static readonly byte[] encodingTable;

		private readonly Stream outStream;

		private int[] buf;

		private int bufPtr;

		private Crc24 crc;

		private int chunkCount;

		private int lastb;

		private bool start;

		private bool clearText;

		private bool newLine;

		private string type;

		private static readonly string nl;

		private static readonly string headerStart;

		private static readonly string headerTail;

		private static readonly string footerStart;

		private static readonly string footerTail;

		private static readonly string Version;

		private readonly IDictionary headers;

		private static void Encode(Stream outStream, int[] data, int len)
		{
		}

		public ArmoredOutputStream(Stream outStream)
		{
		}

		public ArmoredOutputStream(Stream outStream, IDictionary headers)
		{
		}

		public void SetHeader(string name, string v)
		{
		}

		public void ResetHeaders()
		{
		}

		public void BeginClearText(HashAlgorithmTag hashAlgorithm)
		{
		}

		public void EndClearText()
		{
		}

		public override void WriteByte(byte b)
		{
		}

		public override void Close()
		{
		}

		private void DoClose()
		{
		}

		private void WriteHeaderEntry(string name, string v)
		{
		}

		private void DoWrite(string s)
		{
		}
	}
}

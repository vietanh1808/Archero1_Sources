using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpLiteralData : PgpObject
	{
		public const char Binary = 'b';

		public const char Text = 't';

		public const char Utf8 = 'u';

		public const string Console = "_CONSOLE";

		private LiteralDataPacket data;

		public int Format => 0;

		public string FileName => null;

		public DateTime ModificationTime => default;

		public PgpLiteralData(BcpgInputStream bcpgInput)
		{
		}

		public byte[] GetRawFileName()
		{
			return null;
		}

		public Stream GetInputStream()
		{
			return null;
		}

		public Stream GetDataStream()
		{
			return null;
		}
	}
}

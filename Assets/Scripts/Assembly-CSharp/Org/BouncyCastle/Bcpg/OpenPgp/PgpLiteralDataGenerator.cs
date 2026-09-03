using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpLiteralDataGenerator : IStreamGenerator
	{
		public const char Binary = 'b';

		public const char Text = 't';

		public const char Utf8 = 'u';

		public const string Console = "_CONSOLE";

		private BcpgOutputStream pkOut;

		private bool oldFormat;

		public PgpLiteralDataGenerator()
		{
		}

		public PgpLiteralDataGenerator(bool oldFormat)
		{
		}

		private void WriteHeader(BcpgOutputStream outStr, char format, byte[] encName, long modificationTime)
		{
		}

		public Stream Open(Stream outStr, char format, string name, long length, DateTime modificationTime)
		{
			return null;
		}

		public Stream Open(Stream outStr, char format, string name, DateTime modificationTime, byte[] buffer)
		{
			return null;
		}

		public Stream Open(Stream outStr, char format, FileInfo file)
		{
			return null;
		}

		public void Close()
		{
		}
	}
}

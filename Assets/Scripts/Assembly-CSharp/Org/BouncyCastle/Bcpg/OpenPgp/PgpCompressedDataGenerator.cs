using System.IO;
using Org.BouncyCastle.Apache.Bzip2;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpCompressedDataGenerator : IStreamGenerator
	{
		private class SafeCBZip2OutputStream : CBZip2OutputStream
		{
			public SafeCBZip2OutputStream(Stream output)
				: base(null)
			{
			}

			public override void Close()
			{
			}
		}

		private class SafeZOutputStream : ZOutputStream
		{
			public SafeZOutputStream(Stream output, int level, bool nowrap)
				: base(null)
			{
			}

			public override void Close()
			{
			}
		}

		private readonly CompressionAlgorithmTag algorithm;

		private readonly int compression;

		private Stream dOut;

		private BcpgOutputStream pkOut;

		public PgpCompressedDataGenerator(CompressionAlgorithmTag algorithm)
		{
		}

		public PgpCompressedDataGenerator(CompressionAlgorithmTag algorithm, int compression)
		{
		}

		public Stream Open(Stream outStr)
		{
			return null;
		}

		public Stream Open(Stream outStr, byte[] buffer)
		{
			return null;
		}

		private void doOpen()
		{
		}

		public void Close()
		{
		}
	}
}

using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public sealed class SXprUtilities
	{
		private class MyS2k : S2k
		{
			private readonly long mIterationCount64;

			public override long IterationCount => 0L;

			internal MyS2k(HashAlgorithmTag algorithm, byte[] iv, long iterationCount64)
				: base(null)
			{
			}
		}

		private SXprUtilities()
		{
		}

		private static int ReadLength(Stream input, int ch)
		{
			return 0;
		}

		internal static string ReadString(Stream input, int ch)
		{
			return null;
		}

		internal static byte[] ReadBytes(Stream input, int ch)
		{
			return null;
		}

		internal static S2k ParseS2k(Stream input)
		{
			return null;
		}

		internal static void SkipOpenParenthesis(Stream input)
		{
		}

		internal static void SkipCloseParenthesis(Stream input)
		{
		}
	}
}

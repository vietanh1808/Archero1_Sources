using System.Security.Cryptography;

namespace Habby.Archero.Crypto
{
	public class NetEnc
	{
		public const int XOR_NUM = 846337046;

		private const char XOR_MIN = '+';

		public static readonly int[] PUBLIC_KEY;

		public const int XOR_PRIVATE_NUM = 825426240;

		public static readonly int[] PRIVATE_KEY;

		private static RSACryptoServiceProvider rsaPublic;

		private static RSACryptoServiceProvider rsaPrivate;

		public static void init()
		{
		}

		public static byte[] encContent(string content)
		{
			return null;
		}

		public static string decContent(byte[] content)
		{
			return null;
		}

		public static string getContentType()
		{
			return null;
		}
	}
}

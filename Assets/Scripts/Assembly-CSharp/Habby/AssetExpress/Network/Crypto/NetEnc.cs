using System.Security.Cryptography;

namespace Habby.AssetExpress.Network.Crypto
{
	public class NetEnc
	{
		private const int XOR_NUM = 1266245202;

		private const char XOR_MIN = '+';

		private static readonly int[] PUBLIC_KEY;

		private const int XOR_SERVER = 1015866279;

		private const char XOR_MIN_SERVER = '+';

		private static readonly int[] PRIVATE_KEY;

		private static RSACryptoServiceProvider rsaPublic;

		private static RSACryptoServiceProvider rsaPrivate;

		private static void init()
		{
		}

		public static byte[] encContent(byte[] bytes)
		{
			return null;
		}

		public static byte[] encString(string content)
		{
			return null;
		}

		public static byte[] decContent(byte[] content)
		{
			return null;
		}

		public static string decString(byte[] content)
		{
			return null;
		}

		public static string getContentType()
		{
			return null;
		}
	}
}

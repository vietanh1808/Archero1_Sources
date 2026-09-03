using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace Org.BouncyCastle.OpenSsl
{
	public class Pkcs8Generator : PemObjectGenerator
	{
		public static readonly string PbeSha1_RC4_128;

		public static readonly string PbeSha1_RC4_40;

		public static readonly string PbeSha1_3DES;

		public static readonly string PbeSha1_2DES;

		public static readonly string PbeSha1_RC2_128;

		public static readonly string PbeSha1_RC2_40;

		private char[] password;

		private string algorithm;

		private int iterationCount;

		private AsymmetricKeyParameter privKey;

		private SecureRandom random;

		public SecureRandom SecureRandom
		{
			set
			{
			}
		}

		public char[] Password
		{
			set
			{
			}
		}

		public int IterationCount
		{
			set
			{
			}
		}

		public Pkcs8Generator(AsymmetricKeyParameter privKey)
		{
		}

		public Pkcs8Generator(AsymmetricKeyParameter privKey, string algorithm)
		{
		}

		public PemObject Generate()
		{
			return null;
		}
	}
}

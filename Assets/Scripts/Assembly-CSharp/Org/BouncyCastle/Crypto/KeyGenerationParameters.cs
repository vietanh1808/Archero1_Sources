using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto
{
	public class KeyGenerationParameters
	{
		private SecureRandom random;

		private int strength;

		public SecureRandom Random => null;

		public int Strength => 0;

		public KeyGenerationParameters(SecureRandom random, int strength)
		{
		}
	}
}

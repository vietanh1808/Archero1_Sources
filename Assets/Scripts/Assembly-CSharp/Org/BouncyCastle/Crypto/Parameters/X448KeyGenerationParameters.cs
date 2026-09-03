using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class X448KeyGenerationParameters : KeyGenerationParameters
	{
		public X448KeyGenerationParameters(SecureRandom random)
			: base(null, 0)
		{
		}
	}
}

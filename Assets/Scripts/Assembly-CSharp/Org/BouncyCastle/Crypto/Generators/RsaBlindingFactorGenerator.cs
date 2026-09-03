using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	public class RsaBlindingFactorGenerator
	{
		private RsaKeyParameters key;

		private SecureRandom random;

		public void Init(ICipherParameters param)
		{
		}

		public BigInteger GenerateBlindingFactor()
		{
			return null;
		}
	}
}

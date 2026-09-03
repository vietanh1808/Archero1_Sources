using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement
{
	public class DHAgreement
	{
		private DHPrivateKeyParameters key;

		private DHParameters dhParams;

		private BigInteger privateValue;

		private SecureRandom random;

		public void Init(ICipherParameters parameters)
		{
		}

		public BigInteger CalculateMessage()
		{
			return null;
		}

		public BigInteger CalculateAgreement(DHPublicKeyParameters pub, BigInteger message)
		{
			return null;
		}
	}
}

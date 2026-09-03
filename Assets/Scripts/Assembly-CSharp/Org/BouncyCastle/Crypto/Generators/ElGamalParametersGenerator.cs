using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	public class ElGamalParametersGenerator
	{
		private int size;

		private int certainty;

		private SecureRandom random;

		public void Init(int size, int certainty, SecureRandom random)
		{
		}

		public ElGamalParameters GenerateParameters()
		{
			return null;
		}
	}
}

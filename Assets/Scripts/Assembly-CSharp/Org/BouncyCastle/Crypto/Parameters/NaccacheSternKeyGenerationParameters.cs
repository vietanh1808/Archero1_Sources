using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
	{
		private readonly int certainty;

		private readonly int countSmallPrimes;

		public int Certainty => 0;

		public int CountSmallPrimes => 0;

		[Obsolete("Remove: always false")]
		public bool IsDebug => false;

		public NaccacheSternKeyGenerationParameters(SecureRandom random, int strength, int certainty, int countSmallPrimes)
			: base(null, 0)
		{
		}

		[Obsolete("Use version without 'debug' parameter")]
		public NaccacheSternKeyGenerationParameters(SecureRandom random, int strength, int certainty, int countSmallPrimes, bool debug)
			: base(null, 0)
		{
		}
	}
}

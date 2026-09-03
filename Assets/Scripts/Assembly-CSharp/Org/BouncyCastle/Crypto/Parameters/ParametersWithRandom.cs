using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ParametersWithRandom : ICipherParameters
	{
		private readonly ICipherParameters parameters;

		private readonly SecureRandom random;

		public SecureRandom Random => null;

		public ICipherParameters Parameters => null;

		public ParametersWithRandom(ICipherParameters parameters, SecureRandom random)
		{
		}

		public ParametersWithRandom(ICipherParameters parameters)
		{
		}

		[Obsolete("Use Random property instead")]
		public SecureRandom GetRandom()
		{
			return null;
		}
	}
}

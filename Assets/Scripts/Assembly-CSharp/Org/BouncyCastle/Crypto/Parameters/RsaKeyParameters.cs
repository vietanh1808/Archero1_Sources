using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class RsaKeyParameters : AsymmetricKeyParameter
	{
		private static BigInteger SmallPrimesProduct;

		private readonly BigInteger modulus;

		private readonly BigInteger exponent;

		public BigInteger Modulus => null;

		public BigInteger Exponent => null;

		private static BigInteger Validate(BigInteger modulus)
		{
			return null;
		}

		public RsaKeyParameters(bool isPrivate, BigInteger modulus, BigInteger exponent)
			: base(privateKey: false)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}

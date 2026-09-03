using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class RsaSecretBcpgKey : BcpgObject, IBcpgKey
	{
		private readonly MPInteger d;

		private readonly MPInteger p;

		private readonly MPInteger q;

		private readonly MPInteger u;

		private readonly BigInteger expP;

		private readonly BigInteger expQ;

		private readonly BigInteger crt;

		public BigInteger Modulus => null;

		public BigInteger PrivateExponent => null;

		public BigInteger PrimeP => null;

		public BigInteger PrimeQ => null;

		public BigInteger PrimeExponentP => null;

		public BigInteger PrimeExponentQ => null;

		public BigInteger CrtCoefficient => null;

		public string Format => null;

		public RsaSecretBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public RsaSecretBcpgKey(BigInteger d, BigInteger p, BigInteger q)
		{
		}

		public override byte[] GetEncoded()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}

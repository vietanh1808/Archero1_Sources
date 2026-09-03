using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ECDomainParameters
	{
		internal ECCurve curve;

		internal byte[] seed;

		internal ECPoint g;

		internal BigInteger n;

		internal BigInteger h;

		internal BigInteger hInv;

		public ECCurve Curve => null;

		public ECPoint G => null;

		public BigInteger N => null;

		public BigInteger H => null;

		public BigInteger HInv => null;

		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n)
		{
		}

		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
		{
		}

		public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
		{
		}

		public byte[] GetSeed()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		protected virtual bool Equals(ECDomainParameters other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal static ECPoint Validate(ECCurve c, ECPoint q)
		{
			return null;
		}
	}
}

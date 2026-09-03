using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class RsaPublicBcpgKey : BcpgObject, IBcpgKey
	{
		private readonly MPInteger n;

		private readonly MPInteger e;

		public BigInteger PublicExponent => null;

		public BigInteger Modulus => null;

		public string Format => null;

		public RsaPublicBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public RsaPublicBcpgKey(BigInteger n, BigInteger e)
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

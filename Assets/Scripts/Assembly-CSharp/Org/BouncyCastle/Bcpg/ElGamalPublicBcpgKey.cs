using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class ElGamalPublicBcpgKey : BcpgObject, IBcpgKey
	{
		internal MPInteger p;

		internal MPInteger g;

		internal MPInteger y;

		public string Format => null;

		public BigInteger P => null;

		public BigInteger G => null;

		public BigInteger Y => null;

		public ElGamalPublicBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public ElGamalPublicBcpgKey(BigInteger p, BigInteger g, BigInteger y)
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

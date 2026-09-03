using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class DsaPublicBcpgKey : BcpgObject, IBcpgKey
	{
		private readonly MPInteger p;

		private readonly MPInteger q;

		private readonly MPInteger g;

		private readonly MPInteger y;

		public string Format => null;

		public BigInteger G => null;

		public BigInteger P => null;

		public BigInteger Q => null;

		public BigInteger Y => null;

		public DsaPublicBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public DsaPublicBcpgKey(BigInteger p, BigInteger q, BigInteger g, BigInteger y)
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

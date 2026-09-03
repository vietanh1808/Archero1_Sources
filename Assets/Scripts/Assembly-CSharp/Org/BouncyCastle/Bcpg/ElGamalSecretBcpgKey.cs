using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class ElGamalSecretBcpgKey : BcpgObject, IBcpgKey
	{
		internal MPInteger x;

		public string Format => null;

		public BigInteger X => null;

		public ElGamalSecretBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public ElGamalSecretBcpgKey(BigInteger x)
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

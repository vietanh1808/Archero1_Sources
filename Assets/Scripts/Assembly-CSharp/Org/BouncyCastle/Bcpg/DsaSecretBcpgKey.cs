using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class DsaSecretBcpgKey : BcpgObject, IBcpgKey
	{
		internal MPInteger x;

		public string Format => null;

		public BigInteger X => null;

		public DsaSecretBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public DsaSecretBcpgKey(BigInteger x)
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

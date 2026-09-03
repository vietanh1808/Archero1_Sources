using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class ECSecretBcpgKey : BcpgObject, IBcpgKey
	{
		internal MPInteger x;

		public string Format => null;

		public virtual BigInteger X => null;

		public ECSecretBcpgKey(BcpgInputStream bcpgIn)
		{
		}

		public ECSecretBcpgKey(BigInteger x)
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

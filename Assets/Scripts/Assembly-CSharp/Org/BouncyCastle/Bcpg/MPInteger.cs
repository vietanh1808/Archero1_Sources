using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	public class MPInteger : BcpgObject
	{
		private readonly BigInteger val;

		public BigInteger Value => null;

		public MPInteger(BcpgInputStream bcpgIn)
		{
		}

		public MPInteger(BigInteger val)
		{
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}

		internal static void Encode(BcpgOutputStream bcpgOut, BigInteger val)
		{
		}
	}
}

using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg
{
	public class ECDsaPublicBcpgKey : ECPublicBcpgKey
	{
		protected internal ECDsaPublicBcpgKey(BcpgInputStream bcpgIn)
			: base(null)
		{
		}

		public ECDsaPublicBcpgKey(DerObjectIdentifier oid, ECPoint point)
			: base(null)
		{
		}

		public ECDsaPublicBcpgKey(DerObjectIdentifier oid, BigInteger encodedPoint)
			: base(null)
		{
		}
	}
}

using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg
{
	public class ECDHPublicBcpgKey : ECPublicBcpgKey
	{
		private byte reserved;

		private HashAlgorithmTag hashFunctionId;

		private SymmetricKeyAlgorithmTag symAlgorithmId;

		public virtual byte Reserved => 0;

		public virtual HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

		public virtual SymmetricKeyAlgorithmTag SymmetricKeyAlgorithm => SymmetricKeyAlgorithmTag.Null;

		public ECDHPublicBcpgKey(BcpgInputStream bcpgIn)
			: base(null)
		{
		}

		public ECDHPublicBcpgKey(DerObjectIdentifier oid, ECPoint point, HashAlgorithmTag hashAlgorithm, SymmetricKeyAlgorithmTag symmetricKeyAlgorithm)
			: base(null)
		{
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}

		private void VerifyHashAlgorithm()
		{
		}

		private void VerifySymmetricKeyAlgorithm()
		{
		}
	}
}

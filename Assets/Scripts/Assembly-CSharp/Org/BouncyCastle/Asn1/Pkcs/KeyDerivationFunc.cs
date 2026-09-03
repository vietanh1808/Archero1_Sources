using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	public class KeyDerivationFunc : AlgorithmIdentifier
	{
		internal KeyDerivationFunc(Asn1Sequence seq)
			: base((DerObjectIdentifier)null)
		{
		}

		public KeyDerivationFunc(DerObjectIdentifier id, Asn1Encodable parameters)
			: base((DerObjectIdentifier)null)
		{
		}
	}
}

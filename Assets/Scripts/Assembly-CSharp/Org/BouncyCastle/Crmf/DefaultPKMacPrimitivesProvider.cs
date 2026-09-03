using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crmf
{
	public class DefaultPKMacPrimitivesProvider : IPKMacPrimitivesProvider
	{
		public IDigest CreateDigest(AlgorithmIdentifier digestAlg)
		{
			return null;
		}

		public IMac CreateMac(AlgorithmIdentifier macAlg)
		{
			return null;
		}
	}
}

using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	public class GenericKey
	{
		private readonly AlgorithmIdentifier algorithmIdentifier;

		private readonly object representation;

		public AlgorithmIdentifier AlgorithmIdentifier => null;

		public object Representation => null;

		public GenericKey(object representation)
		{
		}

		public GenericKey(AlgorithmIdentifier algorithmIdentifier, byte[] representation)
		{
		}

		public GenericKey(AlgorithmIdentifier algorithmIdentifier, object representation)
		{
		}
	}
}

using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Pkcs
{
	public class Pkcs12StoreBuilder
	{
		private DerObjectIdentifier keyAlgorithm;

		private DerObjectIdentifier certAlgorithm;

		private bool useDerEncoding;

		public Pkcs12Store Build()
		{
			return null;
		}

		public Pkcs12StoreBuilder SetCertAlgorithm(DerObjectIdentifier certAlgorithm)
		{
			return null;
		}

		public Pkcs12StoreBuilder SetKeyAlgorithm(DerObjectIdentifier keyAlgorithm)
		{
			return null;
		}

		public Pkcs12StoreBuilder SetUseDerEncoding(bool useDerEncoding)
		{
			return null;
		}
	}
}

using System.Collections;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	public class OriginatorInfoGenerator
	{
		private readonly IList origCerts;

		private readonly IList origCrls;

		public OriginatorInfoGenerator(X509Certificate origCert)
		{
		}

		public OriginatorInfoGenerator(IX509Store origCerts)
		{
		}

		public OriginatorInfoGenerator(IX509Store origCerts, IX509Store origCrls)
		{
		}

		public virtual OriginatorInfo Generate()
		{
			return null;
		}
	}
}

using System.Collections;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Cms
{
	public class DefaultDigestAlgorithmIdentifierFinder
	{
		private static readonly IDictionary digestOids;

		private static readonly IDictionary digestNameToOids;

		static DefaultDigestAlgorithmIdentifierFinder()
		{
		}

		public AlgorithmIdentifier find(AlgorithmIdentifier sigAlgId)
		{
			return null;
		}

		public AlgorithmIdentifier find(string digAlgName)
		{
			return null;
		}
	}
}

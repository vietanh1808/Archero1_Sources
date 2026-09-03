using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	public class Asn1KeyWrapper : IKeyWrapper
	{
		private string algorithm;

		private IKeyWrapper wrapper;

		public object AlgorithmDetails => null;

		public Asn1KeyWrapper(string algorithm, X509Certificate cert)
		{
		}

		public IBlockResult Wrap(byte[] keyData)
		{
			return null;
		}
	}
}

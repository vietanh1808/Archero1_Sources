using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Cmp
{
	public class RevocationDetails
	{
		private readonly RevDetails revDetails;

		public X509Name Subject => null;

		public X509Name Issuer => null;

		public BigInteger SerialNumber => null;

		public RevocationDetails(RevDetails revDetails)
		{
		}

		public RevDetails ToASN1Structure()
		{
			return null;
		}
	}
}

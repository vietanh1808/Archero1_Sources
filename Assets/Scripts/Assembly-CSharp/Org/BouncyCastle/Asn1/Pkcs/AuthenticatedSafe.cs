namespace Org.BouncyCastle.Asn1.Pkcs
{
	public class AuthenticatedSafe : Asn1Encodable
	{
		private readonly ContentInfo[] info;

		public AuthenticatedSafe(Asn1Sequence seq)
		{
		}

		public AuthenticatedSafe(ContentInfo[] info)
		{
		}

		public ContentInfo[] GetContentInfo()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

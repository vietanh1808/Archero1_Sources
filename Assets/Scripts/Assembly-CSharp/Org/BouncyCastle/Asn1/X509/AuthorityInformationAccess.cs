namespace Org.BouncyCastle.Asn1.X509
{
	public class AuthorityInformationAccess : Asn1Encodable
	{
		private readonly AccessDescription[] descriptions;

		public static AuthorityInformationAccess GetInstance(object obj)
		{
			return null;
		}

		private AuthorityInformationAccess(Asn1Sequence seq)
		{
		}

		public AuthorityInformationAccess(AccessDescription description)
		{
		}

		public AuthorityInformationAccess(DerObjectIdentifier oid, GeneralName location)
		{
		}

		public AccessDescription[] GetAccessDescriptions()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

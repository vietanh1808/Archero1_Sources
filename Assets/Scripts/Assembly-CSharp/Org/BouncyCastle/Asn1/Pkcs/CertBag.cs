namespace Org.BouncyCastle.Asn1.Pkcs
{
	public class CertBag : Asn1Encodable
	{
		private readonly DerObjectIdentifier certID;

		private readonly Asn1Object certValue;

		public DerObjectIdentifier CertID => null;

		public Asn1Object CertValue => null;

		public CertBag(Asn1Sequence seq)
		{
		}

		public CertBag(DerObjectIdentifier certID, Asn1Object certValue)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

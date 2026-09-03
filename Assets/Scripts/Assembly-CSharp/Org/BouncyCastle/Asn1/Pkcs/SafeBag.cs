namespace Org.BouncyCastle.Asn1.Pkcs
{
	public class SafeBag : Asn1Encodable
	{
		private readonly DerObjectIdentifier bagID;

		private readonly Asn1Object bagValue;

		private readonly Asn1Set bagAttributes;

		public DerObjectIdentifier BagID => null;

		public Asn1Object BagValue => null;

		public Asn1Set BagAttributes => null;

		public SafeBag(DerObjectIdentifier oid, Asn1Object obj)
		{
		}

		public SafeBag(DerObjectIdentifier oid, Asn1Object obj, Asn1Set bagAttributes)
		{
		}

		public SafeBag(Asn1Sequence seq)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

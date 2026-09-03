namespace Org.BouncyCastle.Asn1.Pkcs
{
	public class Pfx : Asn1Encodable
	{
		private ContentInfo contentInfo;

		private MacData macData;

		public ContentInfo AuthSafe => null;

		public MacData MacData => null;

		public Pfx(Asn1Sequence seq)
		{
		}

		public Pfx(ContentInfo contentInfo, MacData macData)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

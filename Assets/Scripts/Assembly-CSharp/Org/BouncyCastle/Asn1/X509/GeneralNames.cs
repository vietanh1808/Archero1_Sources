namespace Org.BouncyCastle.Asn1.X509
{
	public class GeneralNames : Asn1Encodable
	{
		private readonly GeneralName[] names;

		public static GeneralNames GetInstance(object obj)
		{
			return null;
		}

		public static GeneralNames GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public GeneralNames(GeneralName name)
		{
		}

		public GeneralNames(GeneralName[] names)
		{
		}

		private GeneralNames(Asn1Sequence seq)
		{
		}

		public GeneralName[] GetNames()
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

namespace Org.BouncyCastle.Asn1.X509
{
	public class CertificatePolicies : Asn1Encodable
	{
		private readonly PolicyInformation[] policyInformation;

		public static CertificatePolicies GetInstance(object obj)
		{
			return null;
		}

		public static CertificatePolicies GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public CertificatePolicies(PolicyInformation name)
		{
		}

		public CertificatePolicies(PolicyInformation[] policyInformation)
		{
		}

		private CertificatePolicies(Asn1Sequence seq)
		{
		}

		public virtual PolicyInformation[] GetPolicyInformation()
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

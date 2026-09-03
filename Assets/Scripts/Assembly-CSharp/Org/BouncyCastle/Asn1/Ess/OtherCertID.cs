using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Ess
{
	[Obsolete("Use version in Asn1.Esf instead")]
	public class OtherCertID : Asn1Encodable
	{
		private Asn1Encodable otherCertHash;

		private IssuerSerial issuerSerial;

		public AlgorithmIdentifier AlgorithmHash => null;

		public IssuerSerial IssuerSerial => null;

		public static OtherCertID GetInstance(object o)
		{
			return null;
		}

		public OtherCertID(Asn1Sequence seq)
		{
		}

		public OtherCertID(AlgorithmIdentifier algId, byte[] digest)
		{
		}

		public OtherCertID(AlgorithmIdentifier algId, byte[] digest, IssuerSerial issuerSerial)
		{
		}

		public byte[] GetCertHash()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

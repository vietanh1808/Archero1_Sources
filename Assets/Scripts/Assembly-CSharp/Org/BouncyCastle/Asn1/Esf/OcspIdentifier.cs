using System;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Asn1.Esf
{
	public class OcspIdentifier : Asn1Encodable
	{
		private readonly ResponderID ocspResponderID;

		private readonly DerGeneralizedTime producedAt;

		public ResponderID OcspResponderID => null;

		public DateTime ProducedAt => default;

		public static OcspIdentifier GetInstance(object obj)
		{
			return null;
		}

		private OcspIdentifier(Asn1Sequence seq)
		{
		}

		public OcspIdentifier(ResponderID ocspResponderID, DateTime producedAt)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

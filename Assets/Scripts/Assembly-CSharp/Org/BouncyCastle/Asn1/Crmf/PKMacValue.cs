using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf
{
	public class PKMacValue : Asn1Encodable
	{
		private readonly AlgorithmIdentifier algID;

		private readonly DerBitString macValue;

		public virtual AlgorithmIdentifier AlgID => null;

		public virtual DerBitString MacValue => null;

		private PKMacValue(Asn1Sequence seq)
		{
		}

		public static PKMacValue GetInstance(object obj)
		{
			return null;
		}

		public static PKMacValue GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public PKMacValue(PbmParameter pbmParams, DerBitString macValue)
		{
		}

		public PKMacValue(AlgorithmIdentifier algID, DerBitString macValue)
		{
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}

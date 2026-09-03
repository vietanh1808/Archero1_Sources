namespace Org.BouncyCastle.Asn1
{
	public class DerSequence : Asn1Sequence
	{
		public static readonly DerSequence Empty;

		public static DerSequence FromVector(Asn1EncodableVector v)
		{
			return null;
		}

		public DerSequence()
			: base(0)
		{
		}

		public DerSequence(Asn1Encodable obj)
			: base(0)
		{
		}

		public DerSequence(params Asn1Encodable[] v)
			: base(0)
		{
		}

		public DerSequence(Asn1EncodableVector v)
			: base(0)
		{
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}

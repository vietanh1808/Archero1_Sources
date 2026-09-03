using System.Collections;

namespace Org.BouncyCastle.Asn1
{
	internal class LazyDerSequence : DerSequence
	{
		private byte[] encoded;

		public override Asn1Encodable this[int index] => null;

		public override int Count => 0;

		internal LazyDerSequence(byte[] encoded)
		{
		}

		private void Parse()
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}

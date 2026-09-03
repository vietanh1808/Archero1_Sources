using System.Collections;

namespace Org.BouncyCastle.Asn1
{
	internal class LazyDerSet : DerSet
	{
		private byte[] encoded;

		public override Asn1Encodable this[int index] => null;

		public override int Count => 0;

		internal LazyDerSet(byte[] encoded)
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

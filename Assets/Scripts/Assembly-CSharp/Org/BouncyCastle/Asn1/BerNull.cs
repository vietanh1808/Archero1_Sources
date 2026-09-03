using System;

namespace Org.BouncyCastle.Asn1
{
	public class BerNull : DerNull
	{
		public new static readonly BerNull Instance;

		[Obsolete("Use static Instance object")]
		public BerNull()
		{
		}

		private BerNull(int dummy)
		{
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}

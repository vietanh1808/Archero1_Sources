using System;

namespace Org.BouncyCastle.Math.EC
{
	public class F2mPoint : AbstractF2mPoint
	{
		public override ECFieldElement YCoord => null;

		protected internal override bool CompressionYTilde => false;

		[Obsolete("Use ECCurve.CreatePoint to construct points")]
		public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
			: base(null, null, null, withCompression: false)
		{
		}

		[Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
		public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
			: base(null, null, null, withCompression: false)
		{
		}

		internal F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
			: base(null, null, null, withCompression: false)
		{
		}

		protected override ECPoint Detach()
		{
			return null;
		}

		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		public override ECPoint Twice()
		{
			return null;
		}

		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		public override ECPoint Negate()
		{
			return null;
		}
	}
}

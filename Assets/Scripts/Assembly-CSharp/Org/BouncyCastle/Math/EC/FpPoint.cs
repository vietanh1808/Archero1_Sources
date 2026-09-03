using System;

namespace Org.BouncyCastle.Math.EC
{
	public class FpPoint : AbstractFpPoint
	{
		[Obsolete("Use ECCurve.CreatePoint to construct points")]
		public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
			: base(null, null, null, withCompression: false)
		{
		}

		[Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
		public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
			: base(null, null, null, withCompression: false)
		{
		}

		internal FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
			: base(null, null, null, withCompression: false)
		{
		}

		protected override ECPoint Detach()
		{
			return null;
		}

		public override ECFieldElement GetZCoord(int index)
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

		public override ECPoint ThreeTimes()
		{
			return null;
		}

		public override ECPoint TimesPow2(int e)
		{
			return null;
		}

		protected virtual ECFieldElement Two(ECFieldElement x)
		{
			return null;
		}

		protected virtual ECFieldElement Three(ECFieldElement x)
		{
			return null;
		}

		protected virtual ECFieldElement Four(ECFieldElement x)
		{
			return null;
		}

		protected virtual ECFieldElement Eight(ECFieldElement x)
		{
			return null;
		}

		protected virtual ECFieldElement DoubleProductFromSquares(ECFieldElement a, ECFieldElement b, ECFieldElement aSquared, ECFieldElement bSquared)
		{
			return null;
		}

		public override ECPoint Negate()
		{
			return null;
		}

		protected virtual ECFieldElement CalculateJacobianModifiedW(ECFieldElement Z, ECFieldElement ZSquared)
		{
			return null;
		}

		protected virtual ECFieldElement GetJacobianModifiedW()
		{
			return null;
		}

		protected virtual FpPoint TwiceJacobianModified(bool calculateW)
		{
			return null;
		}
	}
}

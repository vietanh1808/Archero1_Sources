using UnityEngine;

namespace TableTool
{
	public class Curve_curveModel : LocalModel<Curve_curve, int>
	{
		private const string _Filename = "Curve_curve";

		protected override string Filename => null;

		protected override int GetBeanKey(Curve_curve bean)
		{
			return 0;
		}

		public AnimationCurve GetCurve(int id)
		{
			return null;
		}

		public AnimationCurve GetSin()
		{
			return null;
		}
	}
}

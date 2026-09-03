using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace TableTool
{
	public class Curve_curve : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredString[] _Values;

		private AnimationCurve curve;

		public int ID => 0;

		public string Notes => null;

		public string[] Values => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Curve_curve Copy()
		{
			return null;
		}

		public AnimationCurve GetCurve()
		{
			return null;
		}

		private void InitCurve()
		{
		}
	}
}

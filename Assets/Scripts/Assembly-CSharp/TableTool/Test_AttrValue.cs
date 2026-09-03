using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Test_AttrValue : LocalBean
	{
		private ObscuredString _TypeId;

		private ObscuredString _Notes;

		private ObscuredInt _DeltaValue;

		private ObscuredLong _Startlong;

		private ObscuredBool _Test;

		private ObscuredFloat _Testfloat;

		private ObscuredDouble _Testdouble;

		private ObscuredShort _Testshort;

		private ObscuredInt[] _Testarrayint;

		private ObscuredFloat[] _Testarrayfloat;

		private ObscuredShort[] _Testarrayshort;

		private ObscuredLong[] _Testarraylong;

		private ObscuredDouble[] _Testarraydouble;

		private ObscuredBool[] _Testarraybool;

		private ObscuredString[] _Testarraystring;

		private ObscuredInt _Testint;

		public string TypeId => null;

		public string Notes => null;

		public int DeltaValue => 0;

		public long Startlong => 0L;

		public bool Test => false;

		public float Testfloat => 0f;

		public double Testdouble => 0.0;

		public short Testshort => 0;

		public int[] Testarrayint => null;

		public float[] Testarrayfloat => null;

		public short[] Testarrayshort => null;

		public long[] Testarraylong => null;

		public double[] Testarraydouble => null;

		public bool[] Testarraybool => null;

		public string[] Testarraystring => null;

		public int Testint => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Test_AttrValue Copy()
		{
			return null;
		}
	}
}

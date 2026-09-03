namespace TableTool
{
	public class Altar_EquipBreakModel : LocalModel<Altar_EquipBreak, int>
	{
		private const string _Filename = "Altar_EquipBreak";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_EquipBreak bean)
		{
			return 0;
		}
	}
}

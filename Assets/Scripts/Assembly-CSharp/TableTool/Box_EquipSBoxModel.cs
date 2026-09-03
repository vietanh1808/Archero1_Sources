namespace TableTool
{
	public class Box_EquipSBoxModel : LocalModel<Box_EquipSBox, int>
	{
		private const string _Filename = "Box_EquipSBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_EquipSBox bean)
		{
			return 0;
		}
	}
}

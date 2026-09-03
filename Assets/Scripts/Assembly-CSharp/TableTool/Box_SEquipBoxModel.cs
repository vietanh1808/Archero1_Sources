namespace TableTool
{
	public class Box_SEquipBoxModel : LocalModel<Box_SEquipBox, int>
	{
		private const string _Filename = "Box_SEquipBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_SEquipBox bean)
		{
			return 0;
		}
	}
}

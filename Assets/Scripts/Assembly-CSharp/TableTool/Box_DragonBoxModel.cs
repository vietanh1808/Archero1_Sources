namespace TableTool
{
	public class Box_DragonBoxModel : LocalModel<Box_DragonBox, int>
	{
		private const string _Filename = "Box_DragonBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_DragonBox bean)
		{
			return 0;
		}
	}
}

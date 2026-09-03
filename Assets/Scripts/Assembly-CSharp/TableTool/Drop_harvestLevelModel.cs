namespace TableTool
{
	public class Drop_harvestLevelModel : LocalModel<Drop_harvestLevel, int>
	{
		private const string _Filename = "Drop_harvestLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_harvestLevel bean)
		{
			return 0;
		}
	}
}

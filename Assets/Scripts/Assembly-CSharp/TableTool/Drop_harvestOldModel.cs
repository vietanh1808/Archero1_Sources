namespace TableTool
{
	public class Drop_harvestOldModel : LocalModel<Drop_harvestOld, int>
	{
		private const string _Filename = "Drop_harvestOld";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_harvestOld bean)
		{
			return 0;
		}
	}
}

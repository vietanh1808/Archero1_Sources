namespace TableTool
{
	public class PVEseason_partitionModel : LocalModel<PVEseason_partition, int>
	{
		private const string _Filename = "PVEseason_partition";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_partition bean)
		{
			return 0;
		}
	}
}

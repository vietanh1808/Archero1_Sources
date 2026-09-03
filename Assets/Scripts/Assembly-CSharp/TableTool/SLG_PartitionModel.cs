namespace TableTool
{
	public class SLG_PartitionModel : LocalModel<SLG_Partition, int>
	{
		private const string _Filename = "SLG_Partition";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_Partition bean)
		{
			return 0;
		}
	}
}

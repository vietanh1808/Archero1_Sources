namespace TableTool
{
	public class ShipBattle_PartitionModel : LocalModel<ShipBattle_Partition, int>
	{
		private const string _Filename = "ShipBattle_Partition";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Partition bean)
		{
			return 0;
		}
	}
}

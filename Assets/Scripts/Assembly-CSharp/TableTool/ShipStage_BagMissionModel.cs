namespace TableTool
{
	public class ShipStage_BagMissionModel : LocalModel<ShipStage_BagMission, int>
	{
		private const string _Filename = "ShipStage_BagMission";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_BagMission bean)
		{
			return 0;
		}
	}
}

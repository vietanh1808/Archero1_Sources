namespace TableTool
{
	public class ShipBattle_TalentModel : LocalModel<ShipBattle_Talent, int>
	{
		private const string _Filename = "ShipBattle_Talent";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Talent bean)
		{
			return 0;
		}
	}
}

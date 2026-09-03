namespace TableTool
{
	public class Equip_CastingModel : LocalModel<Equip_Casting, int>
	{
		private const string _Filename = "Equip_Casting";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Casting bean)
		{
			return 0;
		}
	}
}

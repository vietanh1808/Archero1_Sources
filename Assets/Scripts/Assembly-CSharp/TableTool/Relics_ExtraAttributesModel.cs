namespace TableTool
{
	public class Relics_ExtraAttributesModel : LocalModel<Relics_ExtraAttributes, int>
	{
		private const string _Filename = "Relics_ExtraAttributes";

		protected override string Filename => null;

		protected override int GetBeanKey(Relics_ExtraAttributes bean)
		{
			return 0;
		}
	}
}

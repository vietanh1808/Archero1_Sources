namespace TableTool
{
	public class Equip_QualityModel : LocalModel<Equip_Quality, int>
	{
		private const string _Filename = "Equip_Quality";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Quality bean)
		{
			return 0;
		}
	}
}

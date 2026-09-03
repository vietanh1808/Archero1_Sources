namespace TableTool
{
	public class SLG_CampTalentModel : LocalModel<SLG_CampTalent, int>
	{
		private const string _Filename = "SLG_CampTalent";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_CampTalent bean)
		{
			return 0;
		}
	}
}

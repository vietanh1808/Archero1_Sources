namespace TableTool
{
	public class SLG_TalentModel : LocalModel<SLG_Talent, int>
	{
		private const string _Filename = "SLG_Talent";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_Talent bean)
		{
			return 0;
		}
	}
}

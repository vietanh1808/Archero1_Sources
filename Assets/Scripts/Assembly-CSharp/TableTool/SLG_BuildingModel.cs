namespace TableTool
{
	public class SLG_BuildingModel : LocalModel<SLG_Building, int>
	{
		private const string _Filename = "SLG_Building";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_Building bean)
		{
			return 0;
		}
	}
}

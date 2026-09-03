namespace TableTool
{
	public class PVP_PvPConfigModel : LocalModel<PVP_PvPConfig, int>
	{
		private const string _Filename = "PVP_PvPConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(PVP_PvPConfig bean)
		{
			return 0;
		}
	}
}

namespace TableTool
{
	public class PVP_matchModel : LocalModel<PVP_match, int>
	{
		private const string _Filename = "PVP_match";

		protected override string Filename => null;

		protected override int GetBeanKey(PVP_match bean)
		{
			return 0;
		}
	}
}

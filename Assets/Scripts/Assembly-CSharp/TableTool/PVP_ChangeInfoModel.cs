namespace TableTool
{
	public class PVP_ChangeInfoModel : LocalModel<PVP_ChangeInfo, int>
	{
		private const string _Filename = "PVP_ChangeInfo";

		protected override string Filename => null;

		protected override int GetBeanKey(PVP_ChangeInfo bean)
		{
			return 0;
		}
	}
}

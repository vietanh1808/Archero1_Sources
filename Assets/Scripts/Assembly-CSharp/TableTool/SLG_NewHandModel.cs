namespace TableTool
{
	public class SLG_NewHandModel : LocalModel<SLG_NewHand, int>
	{
		private const string _Filename = "SLG_NewHand";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_NewHand bean)
		{
			return 0;
		}
	}
}

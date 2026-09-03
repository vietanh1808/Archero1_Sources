namespace TableTool
{
	public class Altar_BlessModel : LocalModel<Altar_Bless, int>
	{
		private const string _Filename = "Altar_Bless";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_Bless bean)
		{
			return 0;
		}
	}
}

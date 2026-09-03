namespace TableTool
{
	public class Altar_GemBreakModel : LocalModel<Altar_GemBreak, int>
	{
		private const string _Filename = "Altar_GemBreak";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_GemBreak bean)
		{
			return 0;
		}
	}
}

namespace TableTool
{
	public class Runes_RunesModel : LocalModel<Runes_Runes, int>
	{
		private const string _Filename = "Runes_Runes";

		protected override string Filename => null;

		protected override int GetBeanKey(Runes_Runes bean)
		{
			return 0;
		}
	}
}

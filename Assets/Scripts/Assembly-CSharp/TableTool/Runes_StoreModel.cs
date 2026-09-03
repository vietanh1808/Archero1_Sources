namespace TableTool
{
	public class Runes_StoreModel : LocalModel<Runes_Store, int>
	{
		private const string _Filename = "Runes_Store";

		protected override string Filename => null;

		protected override int GetBeanKey(Runes_Store bean)
		{
			return 0;
		}
	}
}

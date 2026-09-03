namespace TableTool
{
	public class Fishing_GiftModel : LocalModel<Fishing_Gift, int>
	{
		private const string _Filename = "Fishing_Gift";

		protected override string Filename => null;

		protected override int GetBeanKey(Fishing_Gift bean)
		{
			return 0;
		}
	}
}

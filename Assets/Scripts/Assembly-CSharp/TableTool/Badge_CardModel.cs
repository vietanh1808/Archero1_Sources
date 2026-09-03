namespace TableTool
{
	public class Badge_CardModel : LocalModel<Badge_Card, int>
	{
		private const string _Filename = "Badge_Card";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_Card bean)
		{
			return 0;
		}
	}
}

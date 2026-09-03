namespace TableTool
{
	public class Bag_BagModel : LocalModel<Bag_Bag, int>
	{
		private const string _Filename = "Bag_Bag";

		protected override string Filename => null;

		protected override int GetBeanKey(Bag_Bag bean)
		{
			return 0;
		}
	}
}

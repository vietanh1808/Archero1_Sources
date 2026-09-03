namespace TableTool
{
	public class Box_BagChoiceBoxModel : LocalModel<Box_BagChoiceBox, int>
	{
		private const string _Filename = "Box_BagChoiceBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_BagChoiceBox bean)
		{
			return 0;
		}
	}
}

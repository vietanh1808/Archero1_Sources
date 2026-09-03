namespace TableTool
{
	public class Box_ChoiceBoxModel : LocalModel<Box_ChoiceBox, int>
	{
		private const string _Filename = "Box_ChoiceBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_ChoiceBox bean)
		{
			return 0;
		}
	}
}

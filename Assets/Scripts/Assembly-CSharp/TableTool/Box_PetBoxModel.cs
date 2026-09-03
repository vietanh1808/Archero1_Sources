namespace TableTool
{
	public class Box_PetBoxModel : LocalModel<Box_PetBox, int>
	{
		private const string _Filename = "Box_PetBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_PetBox bean)
		{
			return 0;
		}
	}
}

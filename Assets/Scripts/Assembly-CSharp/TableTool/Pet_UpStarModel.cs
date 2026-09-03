namespace TableTool
{
	public class Pet_UpStarModel : LocalModel<Pet_UpStar, int>
	{
		private const string _Filename = "Pet_UpStar";

		protected override string Filename => null;

		protected override int GetBeanKey(Pet_UpStar bean)
		{
			return 0;
		}
	}
}

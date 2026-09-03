namespace TableTool
{
	public class Pet_PetModel : LocalModel<Pet_Pet, int>
	{
		private const string _Filename = "Pet_Pet";

		protected override string Filename => null;

		protected override int GetBeanKey(Pet_Pet bean)
		{
			return 0;
		}
	}
}

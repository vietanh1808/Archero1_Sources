namespace TableTool
{
	public class Drop_DropActivityPetModel : LocalModel<Drop_DropActivityPet, int>
	{
		private const string _Filename = "Drop_DropActivityPet";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_DropActivityPet bean)
		{
			return 0;
		}
	}
}

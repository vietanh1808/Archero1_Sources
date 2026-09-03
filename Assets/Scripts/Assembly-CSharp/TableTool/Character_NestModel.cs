namespace TableTool
{
	public class Character_NestModel : LocalModel<Character_Nest, int>
	{
		private const string _Filename = "Character_Nest";

		protected override string Filename => null;

		protected override int GetBeanKey(Character_Nest bean)
		{
			return 0;
		}
	}
}

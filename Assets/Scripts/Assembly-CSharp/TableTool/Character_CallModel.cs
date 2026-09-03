namespace TableTool
{
	public class Character_CallModel : LocalModel<Character_Call, int>
	{
		private const string _Filename = "Character_Call";

		protected override string Filename => null;

		protected override int GetBeanKey(Character_Call bean)
		{
			return 0;
		}
	}
}

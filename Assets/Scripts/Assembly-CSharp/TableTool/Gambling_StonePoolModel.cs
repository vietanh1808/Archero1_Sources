namespace TableTool
{
	public class Gambling_StonePoolModel : LocalModel<Gambling_StonePool, int>
	{
		private const string _Filename = "Gambling_StonePool";

		protected override string Filename => null;

		protected override int GetBeanKey(Gambling_StonePool bean)
		{
			return 0;
		}
	}
}

namespace TableTool
{
	public class Gambling_StoneConfigModel : LocalModel<Gambling_StoneConfig, int>
	{
		private const string _Filename = "Gambling_StoneConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Gambling_StoneConfig bean)
		{
			return 0;
		}
	}
}

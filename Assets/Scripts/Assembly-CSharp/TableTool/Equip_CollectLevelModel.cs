namespace TableTool
{
	public class Equip_CollectLevelModel : LocalModel<Equip_CollectLevel, int>
	{
		private const string _Filename = "Equip_CollectLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_CollectLevel bean)
		{
			return 0;
		}
	}
}

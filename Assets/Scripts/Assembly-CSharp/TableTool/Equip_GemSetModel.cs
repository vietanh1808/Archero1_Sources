namespace TableTool
{
	public class Equip_GemSetModel : LocalModel<Equip_GemSet, int>
	{
		private const string _Filename = "Equip_GemSet";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_GemSet bean)
		{
			return 0;
		}
	}
}

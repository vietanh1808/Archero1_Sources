namespace TableTool
{
	public class Equip_ReplaceModel : LocalModel<Equip_Replace, int>
	{
		private const string _Filename = "Equip_Replace";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Replace bean)
		{
			return 0;
		}
	}
}

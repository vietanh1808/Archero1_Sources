namespace TableTool
{
	public class Equip_RefineModel : LocalModel<Equip_Refine, int>
	{
		private const string _Filename = "Equip_Refine";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Refine bean)
		{
			return 0;
		}
	}
}

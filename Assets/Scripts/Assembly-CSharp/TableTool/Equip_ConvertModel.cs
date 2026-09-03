namespace TableTool
{
	public class Equip_ConvertModel : LocalModel<Equip_Convert, int>
	{
		private const string _Filename = "Equip_Convert";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Convert bean)
		{
			return 0;
		}
	}
}

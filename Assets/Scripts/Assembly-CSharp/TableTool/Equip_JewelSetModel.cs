namespace TableTool
{
	public class Equip_JewelSetModel : LocalModel<Equip_JewelSet, int>
	{
		private const string _Filename = "Equip_JewelSet";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_JewelSet bean)
		{
			return 0;
		}
	}
}

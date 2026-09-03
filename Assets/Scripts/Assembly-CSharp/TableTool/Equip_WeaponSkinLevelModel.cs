namespace TableTool
{
	public class Equip_WeaponSkinLevelModel : LocalModel<Equip_WeaponSkinLevel, int>
	{
		private const string _Filename = "Equip_WeaponSkinLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_WeaponSkinLevel bean)
		{
			return 0;
		}
	}
}

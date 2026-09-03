namespace TableTool
{
	public class Equip_WeaponSkinModel : LocalModel<Equip_WeaponSkin, int>
	{
		private const string _Filename = "Equip_WeaponSkin";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_WeaponSkin bean)
		{
			return 0;
		}
	}
}

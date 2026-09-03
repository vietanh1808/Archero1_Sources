namespace TableTool
{
	public class Equip_ColorfulWeaponSkinModel : LocalModel<Equip_ColorfulWeaponSkin, int>
	{
		private const string _Filename = "Equip_ColorfulWeaponSkin";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_ColorfulWeaponSkin bean)
		{
			return 0;
		}
	}
}

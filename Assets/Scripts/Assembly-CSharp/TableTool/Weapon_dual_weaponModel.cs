namespace TableTool
{
	public class Weapon_dual_weaponModel : LocalModel<Weapon_dual_weapon, int>
	{
		private const string _Filename = "Weapon_dual_weapon";

		protected override string Filename => null;

		protected override int GetBeanKey(Weapon_dual_weapon bean)
		{
			return 0;
		}
	}
}

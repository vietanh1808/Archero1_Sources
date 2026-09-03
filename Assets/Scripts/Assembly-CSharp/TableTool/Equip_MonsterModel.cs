namespace TableTool
{
	public class Equip_MonsterModel : LocalModel<Equip_Monster, int>
	{
		private const string _Filename = "Equip_Monster";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Monster bean)
		{
			return 0;
		}

		public int getMonsterIdByEggId(int EggId)
		{
			return 0;
		}
	}
}

using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Pet_PetBattleSkill : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _EnergeGet;

		private ObscuredInt _EnergeNeed;

		private ObscuredInt _Type;

		private ObscuredString[] _Args;

		private ObscuredInt _Rate;

		private ObscuredInt _PetTarget;

		private ObscuredInt _PositionRange;

		private ObscuredInt _LimitTime;

		private ObscuredInt _RoomEnergyLimit;

		private ObscuredInt _EnergyAdd;

		private ObscuredInt _EnergyAddMaX;

		private ObscuredInt _Cache;

		public int ID => 0;

		public int EnergeGet => 0;

		public int EnergeNeed => 0;

		public int Type => 0;

		public string[] Args => null;

		public int Rate => 0;

		public int PetTarget => 0;

		public int PositionRange => 0;

		public int LimitTime => 0;

		public int RoomEnergyLimit => 0;

		public int EnergyAdd => 0;

		public int EnergyAddMaX => 0;

		public int Cache => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Pet_PetBattleSkill Copy()
		{
			return null;
		}
	}
}

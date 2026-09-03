using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Totem_TotemRefine : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Rare;

		private ObscuredInt _Level;

		private ObscuredString[] _Consume;

		private ObscuredString[] _ConsumeLock1;

		private ObscuredString[] _ConsumeLock2;

		private ObscuredString[] _ConsumeLock3;

		private ObscuredString[] _ConsumeLock4;

		private ObscuredString[] _ConsumeLock5;

		public int Id => 0;

		public int Rare => 0;

		public int Level => 0;

		public string[] Consume => null;

		public string[] ConsumeLock1 => null;

		public string[] ConsumeLock2 => null;

		public string[] ConsumeLock3 => null;

		public string[] ConsumeLock4 => null;

		public string[] ConsumeLock5 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Totem_TotemRefine Copy()
		{
			return null;
		}
	}
}

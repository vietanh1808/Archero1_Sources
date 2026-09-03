using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Operation_move : LocalBean
	{
		private ObscuredInt _MoveStateID;

		private ObscuredString _Notes;

		private ObscuredInt _AttackRemove;

		private ObscuredString[] _Args;

		private ObscuredString _Args_note;

		public int MoveStateID => 0;

		public string Notes => null;

		public int AttackRemove => 0;

		public string[] Args => null;

		public string Args_note => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Operation_move Copy()
		{
			return null;
		}
	}
}

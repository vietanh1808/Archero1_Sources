using System;

namespace MeadowBattle
{
	[Serializable]
	public class SendMatchResultVO
	{
		public bool isWin;

		public ulong target_user;

		public uint[] live_mons;

		public uint[] target_live_mons;

		public uint[] init_mons;

		public bool isAI;

		public SendMatchResultVO Clone()
		{
			return null;
		}
	}
}

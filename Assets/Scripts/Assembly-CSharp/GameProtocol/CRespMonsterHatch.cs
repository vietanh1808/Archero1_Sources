using System.IO;

namespace GameProtocol
{
	public sealed class CRespMonsterHatch : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nBattleCnt;

		public ushort m_nNeedBattleCnt;

		public CMonsterEgg[] m_arrayEgg;

		public CMonsterItem[] m_arrayMonster;

		public string m_strHatchPosition;

		public ushort m_nMonsterBattleBuyCnt;

		public string m_nStrMonsterBattleInfo;

		public ulong m_nTimestamp;

		public uint m_nStep;

		public ushort m_nHatchDoneCount;

		public uint m_nNum;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}

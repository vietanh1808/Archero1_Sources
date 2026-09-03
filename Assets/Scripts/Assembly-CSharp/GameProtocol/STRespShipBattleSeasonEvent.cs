using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespShipBattleSeasonEvent : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nEventID;

		public uint m_nActionID;

		public uint m_nID;

		public uint m_nNum;

		public uint m_nComplete;

		public STShipBattleEventCommonReward m_stCommonReward;

		public uint[] m_vecCommonNum;

		public uint m_nNum2;

		public ulong m_nEventRefreshTime;

		public uint m_nNum3;

		public uint m_nNum4;

		public uint m_nCurActionStatus;

		public uint m_nBagMaxDifficultyId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}

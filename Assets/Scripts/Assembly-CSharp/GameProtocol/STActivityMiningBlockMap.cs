using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityMiningBlockMap : IProtocol
	{
		public uint m_nBlockStartIndex;

		public uint m_nBlockLineIndex;

		public STActivityMiningBlock[] m_vecBlock;

		public Dictionary<ushort, uint[][]> m_mapBlockTypeRewardCfg;

		public uint nPickaxeItemId;

		public uint nDrillItemId;

		public uint nBombItemId;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public Dictionary<ushort, CRewardItem[]> m_mapSpecialBlockRewardItems;

		public bool bCriticalHit;

		public ushort nOperationAreaRowOffset;

		public uint[] m_vecRelicEffectPosIndex;

		public Dictionary<ushort, uint[]> m_mapBlockTypePreviewCfg;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}

using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CEquipmentItem : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public string m_nUniqueID;

		public ulong m_nRowID;

		public uint m_nEquipID;

		public uint m_nLevel;

		public uint m_nFragment;

		public string m_strExtend;

		private const string DragonSkillKey = "dragon_skill";

		public int RelicEvolutionLevel;

		public int RelicStar;

		private LocalSave.EquipOne _one;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public int[] DragonSkillLevels => null;

		private LocalSave.EquipOne one => null;

		public bool IsOverlying => false;

		public bool IsScroll => false;

		public bool IsStone => false;

		public bool IsRuneStone => false;

		public bool IsCharacter => false;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}

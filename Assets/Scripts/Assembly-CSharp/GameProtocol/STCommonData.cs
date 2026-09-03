using System.IO;

namespace GameProtocol
{
	public sealed class STCommonData
	{
		public bool m_nChange;

		public STUserInfo m_stUserInfo;

		public STNormalMap m_StNormalMap;

		public STHeroMap m_stHeroMap;

		public STSlotout m_stSlotout;

		public STEquipment m_stEquipment;

		public STRestore m_stRestore;

		public STTimestamp m_stTimestamp;

		public CRewardItem[] m_vecRewardItem;

		public STSkin m_stSkin;

		public STHead m_stHead;

		public CMonsterEggData m_stMonsterEggData;

		public bool m_nActivityChristmasRedPoint;

		public STCarving m_stCarving;

		private STVipInfo m_stVipInfo;

		public STRelics m_stRelics;

		private STWeaponSkins m_stWeaponSkins;

		private STManorWorkers m_stManorWorkers;

		private STPets m_stPets;

		private STImprintInfos m_stImprints;

		private STWings m_stWings;

		private STHellMap m_stHellMap;

		private STArtifacts m_stArtifacts;

		private STTotems m_stTotems;

		private STColorfulWeaponSkins m_stColorfulWeaponSkin;

		public void ReadFromStream(BinaryReader reader, CCommonRespMsg.ReadOptions opt = null)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}

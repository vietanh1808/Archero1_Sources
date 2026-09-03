using System;
using System.Collections.Generic;
using GameProtocol;
using Habby.Model;
using Newtonsoft.Json;
using UnityEngine;

namespace TableTool
{
	public class Drop_DropModel : LocalModel<Drop_Drop, int>
	{
		[Serializable]
		public class DropData
		{
			public PropType type;

			public int id;

			public int count;

			public int max;

			public long countLong;

			public int days;

			public ulong uniqueid;

			[JsonIgnore]
			public Action OnClose;

			private float numPartPercent;

			public bool IsRange => false;

			[JsonIgnore]
			public bool is_base_currency => false;

			[JsonIgnore]
			public bool can_fly => false;

			[JsonIgnore]
			public bool is_equipexp => false;

			[JsonIgnore]
			public string NameOnlyString => null;

			[JsonIgnore]
			public string InfoString => null;

			[JsonIgnore]
			public string QualityString => null;

			[JsonIgnore]
			public int ePropType => 0;

			[JsonIgnore]
			public int Quality => 0;

			[JsonIgnore]
			public Color QualityColor => default;

			[JsonIgnore]
			public Sprite QualityIcon => null;

			[JsonIgnore]
			public Sprite QualityRandomIcon => null;

			[JsonIgnore]
			public bool IsValid => false;

			[JsonIgnore]
			public bool Overlying => false;

			[JsonIgnore]
			public Sprite Icon => null;

			[JsonIgnore]
			public bool SelfIsEnough => false;

			public float NumPartPercent
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public DropData()
			{
			}

			public DropData(PropType type, int id, int count, int days = 0, long countLong = 0L)
			{
			}

			public bool Equals(DropData data)
			{
				return false;
			}

			public long GetSelfHasCount()
			{
				return 0L;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override string ToString()
			{
				return null;
			}
		}

		public class DropSaveOneData
		{
			public int type;

			public int id;

			public int min;

			public int max;

			public int weight;

			public int count => 0;

			public void Init(string value)
			{
			}

			public int RandomCount()
			{
				return 0;
			}
		}

		private class DropOneIDData
		{
			private Drop_Drop mDropData;

			private DropRandOne mFixedData;

			private List<DropRandOne> list;

			public int DropType => 0;

			public int DropID => 0;

			public DropOneIDData(Drop_Drop data, int dropid)
			{
			}

			public DropOneIDData(Drop_Drop data)
			{
			}

			public List<DropData> GetRandomDrop()
			{
				return null;
			}

			public List<DropData> GetRandomDrop(List<int> filters)
			{
				return null;
			}

			public List<DropData> GetAll()
			{
				return null;
			}

			private int GetPercent(string value)
			{
				return 0;
			}
		}

		private class DropRandOne
		{
			public int RandomPercent;

			private int weight;

			private List<DropSaveOneData> list;

			public void AddOne(string[] value)
			{
			}

			public void AddDropUpOne(string[] value)
			{
			}

			private bool IsDrop()
			{
				return false;
			}

			public DropData GetRandomDrop()
			{
				return null;
			}

			public DropData GetRandomDrop(List<int> filters)
			{
				return null;
			}

			public List<DropData> GetAllDrop()
			{
				return null;
			}
		}

		private const string _Filename = "Drop_Drop";

		private Dictionary<int, DropOneIDData> list;

		private Dictionary<int, DropOneIDData> dropUplist;

		private int golddroproom;

		private float golddroppercent;

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_Drop bean)
		{
			return 0;
		}

		public static DropSaveOneData GetDropOne(string str)
		{
			return null;
		}

		public static DropData GetDropData(Shop_MysticShop data)
		{
			return null;
		}

		public static DropData GetDropData_TIC(int type, int id, int count)
		{
			return null;
		}

		public static DropData GetDropData(int id, int count, int type)
		{
			return null;
		}

		public static DropData GetDropData(uint[] data)
		{
			return null;
		}

		public static DropData GetDropData(int[] data)
		{
			return null;
		}

		public static DropData GetDropData(int id, int count, int type, int days)
		{
			return null;
		}

		public static DropData GetDropData(string str)
		{
			return null;
		}

		public static DropData GetDropData(MailReward reward)
		{
			return null;
		}

		public static DropData GetDrop(CRewardItem item)
		{
			return null;
		}

		public static List<DropData> GetDropDatas(string[] strs)
		{
			return null;
		}

		public static List<DropData> GetDropDatas(int[][] data)
		{
			return null;
		}

		public static List<DropData> GetDropDatas(uint[][] data)
		{
			return null;
		}

		public static bool isBattleID(int dropid)
		{
			return false;
		}

		public List<DropData> GetDropList(int dropid)
		{
			return null;
		}

		public List<DropData> GetDropList(int dropid, List<int> filters)
		{
			return null;
		}

		public List<DropData> GetDropListAll(int dropid)
		{
			return null;
		}

		public float GetGoldDropPercent()
		{
			return 0f;
		}

		public void ClearGoldDrop()
		{
		}

		public int GetDropGold(List<DropData> list)
		{
			return 0;
		}

		public int GetDropDiamond(List<DropData> list)
		{
			return 0;
		}

		public int GetDropKey(List<DropData> list)
		{
			return 0;
		}

		public int GetDropExp(List<DropData> list)
		{
			return 0;
		}

		public int GetDropDiamondBoxNormal(List<DropData> list)
		{
			return 0;
		}

		public int GetDropDiamondBoxLarge(List<DropData> list)
		{
			return 0;
		}

		public List<DropData> GetDropEquips(List<DropData> list)
		{
			return null;
		}

		public List<DropData> GetDiamondBoxNormal()
		{
			return null;
		}

		public List<DropData> GetDiamondBoxLarge()
		{
			return null;
		}

		public List<DropData> GetDiamondBoxNormal10()
		{
			return null;
		}

		public List<DropData> GetDiamondBoxLarge10()
		{
			return null;
		}

		private void GetDiamondBox_ExcuteOne(List<DropData> list, int singleid, int giftid)
		{
		}

		private void GetDiamondBox_ExcuteHave(List<DropData> list, List<DropData> giftlist)
		{
		}

		private void RandomList(List<DropData> list)
		{
		}
	}
}

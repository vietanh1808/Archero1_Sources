using System;
using System.Collections.Generic;
using Dxx.Util;

namespace TableTool
{
	public class Stage_Level_stagechapterModel : LocalModel<Stage_Level_stagechapter, int>
	{
		public class EquipExpDropDataOne : WeightRandomDataBase
		{
			public int count;

			public int min;

			public int max;

			public EquipExpDropDataOne(int id)
				: base(0)
			{
			}

			public List<int> GetRandom()
			{
				return null;
			}
		}

		public class ScrollRandomDataOne : WeightRandomDataBase
		{
			public int ScrollId;

			public ScrollRandomDataOne(int id)
				: base(0)
			{
			}
		}

		public struct EquipExpRandData
		{
			public int Count;

			public int Id;

			public int CurWight;

			public EquipExpRandData(int id, int count, int wight)
			{
				Count = 0;
				Id = 0;
				CurWight = 0;
			}
		}

		public class EquipExpDropData
		{
			public Dictionary<int, WeightRandom<EquipExpDropDataOne>> soldiers;

			public Dictionary<int, WeightRandom<EquipExpDropDataOne>> bosss;

			public Dictionary<int, WeightRandom<ScrollRandomDataOne>> scrollRandom;

			private EquipExpDropDataOne one;

			private List<EquipExpRandData> list;

			private Action<int> _init_data_callback;

			private int _propId;

			public void init(Action<int> action)
			{
			}

			public void init(int id, Action<int, int> action)
			{
			}

			public void add(int stage, string[] data_soldiers, string[] data_bosss, string[] data_scrollRandom, bool isRelicsEffect = false, float improveDropPercent = 0f)
			{
			}

			public List<EquipExpRandData> random(int stage, EntityType type)
			{
				return null;
			}

			public List<EquipExpRandData> random(int stage, EntityType type, Func<float> func)
			{
				return null;
			}

			private EquipExpDropDataOne get(string str, bool isRelicsEffect = false, float improveDropPercent = 0f)
			{
				return null;
			}

			private ScrollRandomDataOne GetScrollItem(string str)
			{
				return null;
			}
		}

		private const string _Filename = "Stage_Level_stagechapter";

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_stagechapter bean)
		{
			return 0;
		}
	}
}

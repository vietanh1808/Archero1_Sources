using System.Collections.Generic;

namespace TableTool
{
	public class Equip_equipModel : LocalModel<Equip_equip, int>
	{
		public class EquipAttribute
		{
			public int Quality;

			public string AttributeDesc;
		}

		private const string _Filename = "Equip_equip";

		private Dictionary<int, List<int>> mQualities;

		private List<int> mEquipExps;

		private List<int> mScrolls;

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_equip bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		private void add_quality(int id, int quality)
		{
		}

		public List<int> GetScrollIds()
		{
			return null;
		}

		public List<int> GetQuality(int quality)
		{
			return null;
		}

		public int RandomByQuality(int quality)
		{
			return 0;
		}

		public int RandomEquipExp()
		{
			return 0;
		}

		public List<Goods_goods.GoodData> GetEquipAttributes(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetDragonEquipAttributes(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<Goods_goods.GoodShowData> GetEquipShowAttrs(LocalSave.EquipOne one, SelfAttributeData selfAttributeShow)
		{
			return null;
		}

		public List<Goods_goods.GoodShowData> GetEquipShowAttrs(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<string> GetEquipAttributesNext(LocalSave.EquipOne one, SelfAttributeData selfAttributeShow)
		{
			return null;
		}

		public List<string> GetEquipAttributesNext(LocalSave.EquipOne one)
		{
			return null;
		}

		public void CheckBabySkill(ref string attr)
		{
		}

		public List<string> GetEquipShowAddAttributes(LocalSave.EquipOne one, bool bSort = true)
		{
			return null;
		}

		public List<EquipAttribute> GetEquipShowAddAttributesWithQuality(LocalSave.EquipOne one, bool bSort = true)
		{
			return null;
		}

		public List<string> GetEquipPreviewAddAttributes(LocalSave.EquipOne one, bool bSort = true)
		{
			return null;
		}

		public List<string> GetRefineEquipShowAddAttributes(LocalSave.EquipOne one, bool bSort = true)
		{
			return null;
		}

		public List<string> GetEquipAddAttributes(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<int> GetSkills(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<int> GetSkillsForCampBattle(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<int> GetSkillsForDaily124(LocalSave.EquipOne one)
		{
			return null;
		}

		public List<int> GetListByPosition(int position)
		{
			return null;
		}

		public int GetAttributeAllCount(LocalSave.EquipOne equipOne)
		{
			return 0;
		}
	}
}

using System.Collections.Generic;
using TableTool;

public class DIYEquipVO
{
	public const string LOG_TAG = "[DIY-EQUIP]";

	public const string INSTALL = "+";

	public const string UNINSTALL = "-";

	public const int SANTA_EQUIP = 1;

	public const int SANTA_COMP = 2;

	private Daily_DiySkillEquips _Meta;

	private LocalSave.EquipOne _EquipOne;

	public int Id { get; private set; }

	public Daily_DiySkillEquips Meta => null;

	public LocalSave.EquipOne EquipOne => null;

	public DIYEquipVO(int id)
	{
	}

	public bool IsSantaEquip()
	{
		return false;
	}

	public bool IsSantaComp()
	{
		return false;
	}

	public float GetDropRate(bool isBoss)
	{
		return 0f;
	}

	public int GetWeaponId()
	{
		return 0;
	}

	public string GetWeaponHandId()
	{
		return null;
	}

	public void SetId(int _id)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void ExcuteAttr(EntityBase entity, string sign)
	{
	}

	public void UpdateSkills(EntityBase entity, string sign)
	{
	}

	public List<Goods_goods.GoodData> GetAttrs()
	{
		return null;
	}

	public List<int> GetSkills()
	{
		return null;
	}

	public string GetDesc()
	{
		return null;
	}
}

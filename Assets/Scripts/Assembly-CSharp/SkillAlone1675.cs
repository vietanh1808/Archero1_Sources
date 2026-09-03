using System.Collections.Generic;
using TableTool;

public class SkillAlone1675 : SkillAloneMagicBookBase
{
	private const string DropOneHp = "DropHp_1%";

	private const string DropTwoHp = "DropHp_2%";

	private const string DropThreeHp = "DropHp_3%";

	private const string DropFourHp = "DropHp_4%";

	private const string Time = "Time";

	private const string Buff1Id = "Buff1Id";

	private const string AbsorbHPFoodMax = "AbsorbHPFoodMax";

	private const string EnergyAdd = "EnergyAdd";

	private const string AngelMax = "AngelMax";

	private float m_fDropOneHpWeight;

	private float m_fDropTwoHpWeight;

	private float m_fDropThreeHpWeight;

	private float m_fDropFourHpWeight;

	private float m_fDuration;

	private int m_nAbsorbHPFoodMax;

	private int m_nEnergyAdd;

	private int m_nAngelMax;

	private List<int> m_listAbsorbHpBuffs;

	private List<string> m_listHpFoodIds;

	private int m_nHpFoodCnt;

	private int m_nAngelCnt;

	private bool m_bBreakOut;

	private const string String_CallID = "CallID";

	private new const string String_Time = "PartTime";

	private const string String_Weight = "Weight";

	private const string String_PartLimit = "PartLimit";

	private const string String_TotalPartLimit = "TotalPartLimit";

	private const string String_PartBossLimit = "PartBossLimit";

	private const string String_HpTrans = "HpTrans";

	protected int partid;

	private float time;

	private int weight;

	private int part_limit;

	private int part_boss_limit;

	private int total_part_limit;

	private int hp_trans;

	private new List<string> m_listAttrs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	protected override void OnEnergyChange()
	{
	}

	private void DropHp()
	{
	}

	private void OnAbsorbHp(FoodBase food)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnAttackPre()
	{
	}

	private bool ExcutePartBodyParams(Goods_goods.GoodData data)
	{
		return false;
	}

	private void CreatePartBody()
	{
	}
}

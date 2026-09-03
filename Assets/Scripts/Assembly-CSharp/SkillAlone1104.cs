using System.Collections.Generic;

public class SkillAlone1104 : SkillAloneBase
{
	private new const string Tag = "SkillAlone1104";

	private const string String_Num = "Num";

	private const string String_AttackValuePercent = "AttackValue%";

	private const string String_AttackSpeedPercent = "AttackSpeed%";

	private const string String_CritRatePercent = "CritRate%";

	private const string String_CritValuePercent = "CritValue%";

	private const string String_BodyHittedReducePercent = "BodyHittedReduce%";

	private const string String_BulletReducePercent = "BulletReduce%";

	private const string String_MissRatePercent = "MissRate%";

	private int m_nNum;

	private int m_nAttrValue;

	private string m_strAttribute;

	private bool m_bAddedBuffFlag;

	protected override void OnInstall()
	{
	}

	protected virtual void Excute(string str)
	{
	}

	private void OnEnemiesCntChanged(List<EntityBase> list)
	{
	}

	private void update_buff(bool add)
	{
	}

	private void OnGotoNextRoom()
	{
	}

	protected override void OnUninstall()
	{
	}
}

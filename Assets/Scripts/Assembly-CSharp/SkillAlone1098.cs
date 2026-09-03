public class SkillAlone1098 : SkillAloneBase
{
	private const string String_Weight_Poison = "Weight_Poison";

	private const string String_Weight_Thunder = "Weight_Thunder";

	private const string String_Weight_Fire = "Weight_Fire";

	private const string String_Weight_Ice = "Weight_Ice";

	private int Weight_Poison;

	private int Weight_Thunder;

	private int Weight_Fire;

	private int Weight_Ice;

	private int totalWeight;

	private int Debuff_Poison_Id;

	private int Debuff_Thunder_Id;

	private int Debuff_Fire_Id;

	private int Debuff_Ice_Id;

	protected EElementType m_emLastType;

	protected int m_nDebuffId;

	private ActionBasic action;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void Excute(string str)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackContinuePre()
	{
	}

	private void OnAttackPre()
	{
	}

	private void OnAttackEnd()
	{
	}

	protected virtual void RandomDebuff()
	{
	}

	private void RemoveDebuff()
	{
	}

	private void AddDebuff()
	{
	}
}

public class SkillAlone1001 : SkillAloneBase
{
	private const int ADD = 1;

	private const int REMOVE = 2;

	private const string String_AttackSpeedFromParentMaxPercent = "AttackSpeedFromParentMax%";

	private const string String_CritRateFromParentMaxPercent = "CritRateFromParentMax%";

	private const string String_AttackFromParentMaxPercent = "AttackFromParentMax%";

	private const string String_CritValueFromParentMaxPercent = "CritValueFromParentMax%";

	private int skillid;

	private int m_nAttackSpeedFromParentMaxPercent;

	private int m_nCritRateFromParentMaxPercent;

	private int m_nAttackFromParentMaxPercent;

	private int m_nCritValueFromParentMaxPercent;

	private int m_nTotalAttackValue;

	private int m_nParentTotalAttackValue;

	private string m_strOldAttackValueAttr;

	private int m_nTotalCritRate;

	private int m_nParentTotalCritRate;

	private string m_strOldCritRateAttr;

	private int m_nTotalAttackSpeed;

	private int m_nParentTotalAttackSpeed;

	private string m_strOldAttackSpeedAttr;

	private int m_nTotalCritValue;

	private int m_nParentTotalCritValue;

	private string m_strOldCritValueAttr;

	protected override void OnInstall()
	{
	}

	private void OnCreateBaby()
	{
	}

	private void Excute(string param, int sign = 1)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackSpeedUpdate(int value)
	{
	}

	private void OnCritRateUpdate(int value)
	{
	}

	private void OnAttackUpdate(float value)
	{
	}

	private void OnCritValueUpdate(int value)
	{
	}

	private void UpdateAttribute(int value, string name, ref string oldAttr, ref int totalValue, ref int parentTotalValue, int max)
	{
	}
}

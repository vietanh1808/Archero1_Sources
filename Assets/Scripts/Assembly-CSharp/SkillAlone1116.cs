public class SkillAlone1116 : SkillAloneMagicBookBase
{
	private const string Time = "Time";

	private const string UPDATE_NAME = "Update-SkillAlone1116";

	private float m_fDuration;

	private float m_fTime;

	private int m_nEnergySkillNumMax;

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

	private void onUpdate(float deltaTime)
	{
	}

	protected override bool OnEnergyFull()
	{
		return false;
	}

	protected override void UpdateEnergyMax()
	{
	}

	private void ResetEnergyMax()
	{
	}
}

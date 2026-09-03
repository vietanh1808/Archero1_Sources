using UnityEngine;

public class SkillAlone4068 : SkillAlone2111
{
	private Coroutine m_coroutine;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnRecvCustomCommand(CustomJsonDataCommand command, CustomJsonActionVO data)
	{
	}

	protected override bool DoCreateGoldBall()
	{
		return false;
	}
}

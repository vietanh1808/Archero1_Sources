using UnityEngine;

public class SkillAlone1974 : SkillAloneBase
{
	private float killEnemyImproveCrit;

	private float killEnemyMaxImproveCrit;

	private LocalSave.Skill1974VO Skill1974VO => null;

	private float HaveAddCritRate => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	private bool CanAddCritRate()
	{
		return false;
	}

	private void OnCreatePlayer()
	{
	}
}

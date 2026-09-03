using UnityEngine;

public class SkillAlone1706 : SkillAlone1033
{
	private const int PART_ID = 1841;

	private bool isUsingArcherToy;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void Excute(string str, bool bExcute = false)
	{
	}

	private void OnKill(EntityBase entity, Vector3 vector, HitStruct @struct)
	{
	}

	protected override bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected override EntityPartBodyBase CallOne(EntityBase entity, bool CallPlusOne = false)
	{
		return null;
	}
}

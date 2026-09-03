using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2199 : SkillAlone2194
{
	private Dictionary<int, float> m_dicHeroFlySwordRatio;

	protected override EntityBase Target => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected override void SyncFlySword(Vector3 startPos, float angle, int uid)
	{
	}
}

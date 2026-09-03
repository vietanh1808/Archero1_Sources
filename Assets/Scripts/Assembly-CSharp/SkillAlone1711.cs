using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1711 : SkillAloneBase
{
	private int CONFIG_ROTATE_SWORD_MAX;

	private float CONFIG_ROTATE_SWORD_RATE;

	private float CONFIG_ROTATE_SWORD_SPEED;

	private float CONFIG_ROTATE_SWORD_RADIUS;

	private int CONFIG_FLY_SWORD_ID;

	private float CONFIG_FLY_SWORD_RATE;

	private float CONFIG_FLY_SWORD_HIT_RATIO;

	private int CONFIG_DIVIDE_SWORD_ID;

	private float CONFIG_DIVIDE_SWORD_DEGREE;

	private float CONFIG_DIVIDE_SWORD_RATE;

	private float CONFIG_SECTOR_ANGLE;

	private float CONFIG_DIVIDE_SWORD_HIT_RATIO;

	private int m_nRotateSwordCnt;

	private List<SkillAlone1711GoodCtrl> m_listRotateMulanSwords;

	private float m_fStartDegree;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackEndEnd()
	{
	}

	private void OnLevelUp(int lv)
	{
	}

	private void AddRotateMulanSword()
	{
	}

	private void DeInitRotateSwords()
	{
	}

	private void CreateFlySword(Vector3 startpos, float angle)
	{
	}
}

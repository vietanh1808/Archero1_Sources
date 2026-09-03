using System;
using UnityEngine;

[Serializable]
public class SyncCommonPartBodyVO : CustomJsonActionVO
{
	public Vector3 position;

	public string[] attrs;

	public int partId;

	public int aliveTime;

	public int[] skillArray;

	public int weaponId;

	public int[] elementDebuffs;

	public float deltaBodyScale;

	public float parentAttackSpeed;

	public int[] parentSkillIds;
}

using System;
using UnityEngine;

[Serializable]
public class SyncHammerHitVO : CustomJsonActionVO
{
	public int weaponId;

	public Vector3 bulletPos;

	public Vector3 bulletDir;
}

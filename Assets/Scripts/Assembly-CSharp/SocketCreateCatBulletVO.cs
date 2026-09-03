using System;
using UnityEngine;

[Serializable]
public class SocketCreateCatBulletVO : CustomJsonActionVO
{
	public int BulletId;

	public Vector3 BulletPos;

	public float Angle;

	public int TargetGuid;

	public float AttackRatio;

	public int DebuffId;
}

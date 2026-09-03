using System;
using UnityEngine;

[Serializable]
public class SocketShieldReboundBulletVO : CustomJsonActionVO
{
	public int bulletId;

	public Vector3 pos;

	public float angle;

	public SocketShieldReboundBulletVO(string action, in int _bulletId, in Vector3 _pos, in float _angle)
	{
	}
}

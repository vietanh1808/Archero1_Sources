using System;
using UnityEngine;

[Serializable]
public class SocketBulletVO : CustomJsonActionVO
{
	public Vector3 offsetpos;

	public float rota;

	public Vector3 pos;

	public int bulletId;

	public int targetGuid;
}

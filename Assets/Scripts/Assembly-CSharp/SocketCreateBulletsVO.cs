using System;
using UnityEngine;

[Serializable]
public class SocketCreateBulletsVO : CustomJsonActionVO
{
	public Vector3[] arrPos;

	public Vector3 offsetpos;

	public float rota;

	public int bulletId;

	public int targetGuid;

	public float pertime;
}

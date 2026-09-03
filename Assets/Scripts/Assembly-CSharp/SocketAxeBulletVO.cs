using System;
using UnityEngine;

[Serializable]
public class SocketAxeBulletVO : CustomJsonActionVO
{
	public int guid;

	public int bulletId;

	public Vector3 bulletPos;

	public Vector3 bulletDir;

	public float startRadius;
}

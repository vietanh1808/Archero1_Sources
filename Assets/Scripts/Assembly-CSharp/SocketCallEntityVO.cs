using System;
using UnityEngine;

[Serializable]
public class SocketCallEntityVO : CustomJsonActionVO
{
	public int callId;

	public int entityId;

	public Vector3 pos;

	public bool isElite;
}

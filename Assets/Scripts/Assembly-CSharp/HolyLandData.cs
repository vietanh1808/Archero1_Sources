using UnityEngine;

public struct HolyLandData
{
	public Vector3 pos;

	public HolyLandType type;

	public HolyLandData(Vector3 pos, HolyLandType type)
	{
		this.pos = default;
		this.type = HolyLandType.Line;
	}
}

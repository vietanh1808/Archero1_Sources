using UnityEngine;

public class RedLineCtrl5301 : RedLineCtrl
{
	protected override void getReflectAngle(ref float resultangle, float incidenceAngle, Vector3 hitPos, int index)
	{
	}

	private float getOffsetAngle(Vector3 reflectDir, Vector3 dir, float incidenceAngle, float resultangle, float offsetAngle)
	{
		return 0f;
	}

	protected override GameObject getRedLineResource()
	{
		return null;
	}

	protected override Transform getRedLineNode()
	{
		return null;
	}

	protected override Transform getOriginalTrans()
	{
		return null;
	}
}

using UnityEngine;

public class Bullet5349 : Bullet5017
{
	private int m_nReboundWallCnt;

	protected override bool OnThroughWalls(Collider o)
	{
		return false;
	}

	protected override void OnDeInit()
	{
	}
}

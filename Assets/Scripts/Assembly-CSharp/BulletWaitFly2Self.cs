using UnityEngine;

public class BulletWaitFly2Self : BulletBase
{
	private bool bStart;

	[Header("等待时间")]
	public float waitTime;

	private Vector3 mEndPos;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}
}

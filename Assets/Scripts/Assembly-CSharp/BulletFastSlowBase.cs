using UnityEngine;

public class BulletFastSlowBase : BulletBase
{
	private AnimationCurve curve;

	private float time;

	[Header("曲线变化总时间")]
	public float alltime;

	[Header("速度增加系数")]
	public float speedratio;

	protected override void OnInit()
	{
	}

	private void InitCurve()
	{
	}

	protected override void OnUpdate()
	{
	}
}

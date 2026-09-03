using UnityEngine;

public class BulletSlopeCreateBase : BulletSlopeBase
{
	[Header("分裂石头ID")]
	public int DivideID;

	[Header("分裂石头数量")]
	public int DivideCount;

	[Header("分裂石头初始角度偏移")]
	public int AngelOffset;

	[Header("分裂石头高度")]
	public float Height;

	[Header("分裂石头初始前进距离")]
	public float ForwardLength;

	private Vector3 shadowScaleInit;

	private float height;

	private CapsuleCollider bulletCollider;

	public float Radius { get; set; }

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnOverDistance()
	{
	}

	protected override void OnDeInit()
	{
	}
}

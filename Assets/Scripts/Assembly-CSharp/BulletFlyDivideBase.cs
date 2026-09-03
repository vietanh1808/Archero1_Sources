using UnityEngine;

public class BulletFlyDivideBase : BulletBase
{
	[Header("分裂石头ID")]
	public int DivideID;

	[Header("分裂石头数量")]
	public int DivideCount;

	[Header("分裂石头初始角度偏移")]
	public int AngelOffset;

	[Header("分裂石头初始角度是否根据父子弹角度")]
	public bool DependBulletAngle;

	[Header("创建分裂石头时间间隔")]
	public float DivideTime;

	[Header("清除子弹父亲属性")]
	public bool ClearAttribute;

	private float updatetime;

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void CreateDivideBullet()
	{
	}
}

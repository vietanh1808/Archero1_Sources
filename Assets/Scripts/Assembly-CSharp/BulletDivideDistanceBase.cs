using UnityEngine;

public class BulletDivideDistanceBase : BulletBase
{
	[Header("分裂石头ID")]
	public int DivideID;

	[Header("分裂石头数量")]
	public int DivideCount;

	[Header("分裂石头初始角度偏移")]
	public int AngelOffset;

	[Header("清除子弹父亲属性")]
	public bool ClearAttribute;

	[Header("子弹飞行多远分裂")]
	public float DivideDistance;

	[Header("如果没有分裂过，子弹销毁时分裂")]
	public bool EndDivide;

	private bool bDivide;

	protected override void OnInit()
	{
	}

	protected override void OnHitWall()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void create_bullets()
	{
	}
}

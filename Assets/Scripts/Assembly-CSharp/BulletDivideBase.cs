using UnityEngine;

public class BulletDivideBase : BulletBase
{
	[Header("分裂石头ID")]
	public int DivideID;

	[Header("分裂石头数量")]
	public int DivideCount;

	[Header("分裂石头初始角度偏移")]
	public int AngelOffset;

	[Header("清除子弹父亲属性")]
	public bool ClearAttribute;

	protected override void OnHitWall()
	{
	}

	protected override void OnOverDistance()
	{
	}
}

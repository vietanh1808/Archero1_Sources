using UnityEngine;

public class BulletDivideRangeBase : BulletBase
{
	[Header("分裂石头ID")]
	public int DivideID;

	[Header("分裂石头数量")]
	public int DivideCount;

	[Header("角度min")]
	public int angle_min;

	[Header("角度max")]
	public int angle_max;

	[Header("角度随机")]
	public int angle_random;

	[Header("清除子弹父亲属性")]
	public bool ClearAttribute;

	protected override void OnHitWall()
	{
	}

	protected override void OnOverDistance()
	{
	}
}

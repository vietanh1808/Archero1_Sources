using UnityEngine;

public class Goods1004 : GoodsBase
{
	private Animator ani;

	private const string ShowAni = "spike_trap_show";

	private const string HideAni = "spike_trap_hide";

	private const string ShowPara = "Show";

	protected bool bStartTrap;

	protected float trapTime;

	protected int framecount;

	protected override void Init()
	{
	}

	protected override void AwakeInit()
	{
	}

	public override void ChildTriggerEnter(GameObject o)
	{
	}

	protected override void UpdateProcess()
	{
	}
}

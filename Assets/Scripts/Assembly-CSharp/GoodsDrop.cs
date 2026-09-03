using System;
using UnityEngine;

public class GoodsDrop : MonoBehaviour
{
	private FoodBase mFoodBase;

	private Func<int> callback;

	private Action mDropEndAction;

	private Animator Drop_ani;

	private bool Drop_Update;

	private float Drop_x;

	private float Drop_y;

	private float Drop_StartTime;

	private float Drop_startx;

	private float Drop_starty;

	protected float Drop_jumpTime;

	private bool bDelay;

	private float Delay_Time;

	private bool bDropEndAction;

	private float percent;

	protected virtual string JumpAnimation => null;

	public void SetCallBack(Func<int> callback)
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
	}

	protected void OnAwake()
	{
	}

	private void InitDropAni(Action complete)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void set_dropani_enable(bool value)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void SetDropEnd(Action callback)
	{
	}

	public void DropInitLast(Vector3 startpos, Vector3 endpos)
	{
	}

	private void DropUpdateProcess()
	{
	}
}

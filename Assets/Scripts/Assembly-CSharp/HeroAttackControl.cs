using UnityEngine;

public class HeroAttackControl : AttackControl
{
	private bool bAttackUpdate;

	protected EntityBase m_LastTarget;

	private EntityBase _target;

	private GameObject m_TargetImageP;

	private GameObject m_TargetRedP;

	private Animation _TargetAni;

	private bool showTarget;

	private Vector3 TargetPos;

	public bool AttackUpdate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject TargetImage => null;

	protected GameObject TargetRed => null;

	public Animation TargetAni => null;

	protected override void OnStart()
	{
	}

	protected override void OnDestroys()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public override void UpdateProgress()
	{
	}

	protected void DoRealAttackWrapper()
	{
	}

	protected void DoRealAttack()
	{
	}

	protected virtual void AutoAttackUpdate()
	{
	}

	protected virtual bool CheckTarget()
	{
		return false;
	}

	protected void FindTarget()
	{
	}

	public override void MoveEndCallBack()
	{
	}

	public void ReSearchTarget()
	{
	}

	protected void SetCurrentTarget()
	{
	}

	protected void MissTargetImage()
	{
	}

	protected void CheckCurrentTarget()
	{
	}

	private void CreateTarget()
	{
	}

	public override void Reset()
	{
	}

	protected virtual void OnPVP_TouchStart(JoyData data)
	{
	}

	protected virtual void OnPVP_Touching(JoyData data)
	{
	}

	protected virtual void OnPVP_TouchEnd(JoyData data)
	{
	}
}

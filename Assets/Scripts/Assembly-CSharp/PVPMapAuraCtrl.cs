using UnityEngine;

public class PVPMapAuraCtrl : CommonAuraCtrl
{
	[SerializeField]
	private GameObject CountDownEff;

	private EntityBase target;

	private int goodId;

	private int x;

	private int y;

	private float enterTime;

	private float sendBuffDuration;

	private int buffId;

	private int countDownEffId;

	public void SetParams(int goodId, int x, int y, int buffId, float duration, int countDownEffId)
	{
	}

	protected override void OnEnterAuraCollider(EntityBase e)
	{
	}

	protected override void OnStayAuraCollider(EntityBase e)
	{
	}

	protected override void OnExitAuraCollider(EntityBase e)
	{
	}

	private new void DestroySelf()
	{
	}

	private void SyncPVPAuraDestroy(int GoodId, int x, int y)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}

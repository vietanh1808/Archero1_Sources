using UnityEngine;

public class Act5thHuntingSweepItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl sweepBtn;

	[SerializeField]
	private DxxText sweepBtnName;

	private int sweepCount;

	private bool isInit;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingBaseData HuntingBaseData => null;

	private Act5thHuntingSceneData HuntingSceneData => null;

	private int CurSceneID => 0;

	private int SweepOneNeedTicket => 0;

	private int CurSweepNeedTicket => 0;

	private bool HaveEnoughCurrencySweep => false;

	private void Init()
	{
	}

	public void Refresh(int sweepCount)
	{
	}

	private void ClickSweepBtn()
	{
	}

	private void RequestSweep(int costHuntingTicket)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;

public class GrowthFundItem : MonoBehaviour
{
	[SerializeField]
	private DxxText txtLevel;

	[SerializeField]
	private DxxText txtClaimPremium;

	[SerializeField]
	private DxxText txtClaimNormal;

	[SerializeField]
	private DxxText txtClaimFree;

	[SerializeField]
	private BattlePass_BigPropOne propFree;

	[SerializeField]
	private BattlePass_BigPropOne propNormal;

	[SerializeField]
	private BattlePass_BigPropOne propPremium;

	[SerializeField]
	private GameObject goLockPremium;

	[SerializeField]
	private GameObject goLockNormal;

	[SerializeField]
	private GameObject goLockFree;

	[SerializeField]
	private GameObject goClaimedPremium;

	[SerializeField]
	private GameObject goClaimedNormal;

	[SerializeField]
	private GameObject goClaimedFree;

	[SerializeField]
	private GameObject goTipPremium;

	[SerializeField]
	private GameObject goTipNormal;

	[SerializeField]
	private GameObject goTipFree;

	[SerializeField]
	private GameObject goConnectUp;

	[SerializeField]
	private GameObject goConnectDown;

	public Image Image_BG;

	public Color[] colorTop;

	public Color[] colorBottom;

	private int index;

	private const byte FREE = 0;

	private const byte NORMAL = 1;

	private const byte PREMIUM = 2;

	private bool IsClaimed(byte type)
	{
		return false;
	}

	private bool IsLevelEnough()
	{
		return false;
	}

	public void SetData(int index)
	{
	}

	private void OnBtnFreeClick(PropOneBase item, object param)
	{
	}

	private void OnBtnNormalClick(PropOneBase item, object param)
	{
	}

	private void OnBtnPremiumClick(PropOneBase item, object param)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshProp()
	{
	}

	private void RefreshState()
	{
	}

	public void RefreshBG()
	{
	}
}

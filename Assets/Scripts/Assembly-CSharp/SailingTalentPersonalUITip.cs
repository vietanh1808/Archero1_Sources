using UnityEngine;
using UnityEngine.UI;

public class SailingTalentPersonalUITip : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private DxxText attribute;

	[SerializeField]
	private DxxText currencyACount;

	[SerializeField]
	private DxxText currencyBCount;

	[SerializeField]
	private GameObject currencyA;

	[SerializeField]
	private GameObject currencyB;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private DxxText upgradeNeedCount;

	[SerializeField]
	private DxxText clickName;

	[SerializeField]
	private DxxText lockText;

	[SerializeField]
	private DxxText rewardTitle;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private GameObject allFinish;

	[SerializeField]
	private GameObject reward;

	[SerializeField]
	private Image currencyIcon;

	private SailingTalentPersonalProgressItemData data;

	private SailingTalentManager SailingTalentManager => null;

	public void Show(SailingTalentPersonalProgressItemData data)
	{
	}

	public void Close()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshStatus()
	{
	}

	public (int, int) GetCurrencyAbCount()
	{
		return default;
	}

	public string GetLockText()
	{
		return null;
	}

	private void Click()
	{
	}

	public void Disable()
	{
	}

	private void Esc()
	{
	}
}

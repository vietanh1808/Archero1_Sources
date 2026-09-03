using UnityEngine;
using UnityEngine.UI;

public class BattlePass_PropOne : PropOneEquip
{
	[Header("battlepass")]
	public GameObject getIcon;

	public GameObject lockIcon;

	public GameObject canGetIcon;

	public GameObject canGetForm;

	public GameObject canGetTitle;

	public Text rewardText;

	public override void SetAlreadyGet(bool alreadyget)
	{
	}

	public void SetLock(bool isLock)
	{
	}

	public virtual void SetCanGet(bool canGet)
	{
	}

	public virtual void SetCurIndex(bool isCur)
	{
	}
}

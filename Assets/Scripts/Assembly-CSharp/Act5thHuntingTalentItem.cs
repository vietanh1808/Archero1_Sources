using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingTalentItem : MonoBehaviour
{
	[SerializeField]
	private DxxText talentLevel;

	[SerializeField]
	private new FitContentText name;

	[SerializeField]
	private GameObject lockStatus;

	[SerializeField]
	private GameObject unlockStatus;

	[SerializeField]
	private Image talentIcon;

	[SerializeField]
	private Image lockIcon;

	[SerializeField]
	private Image frameIcon;

	[SerializeField]
	private GameObject randomSelectStatus;

	[SerializeField]
	private ButtonCtrl clickBtn;

	private Act5thHuntingTalentItemData data;

	private bool isInit;

	private void Init()
	{
	}

	public void Refresh(Act5thHuntingTalentItemData data)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	public void SetRandomSelectStatus(bool active)
	{
	}

	private void ClickBtn()
	{
	}
}

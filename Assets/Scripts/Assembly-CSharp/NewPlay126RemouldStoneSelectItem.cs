using UnityEngine;
using UnityEngine.UI;

public class NewPlay126RemouldStoneSelectItem : MonoBehaviour
{
	[SerializeField]
	private Image stoneIcon;

	[SerializeField]
	private Image stoneQuality;

	[SerializeField]
	private GameObject selectStatus;

	[SerializeField]
	private ButtonCtrl selectBtn;

	private bool isInit;

	private NewPlay126MonsterRemouldStoneDropItemData stoneData;

	private NewPlay126MonsterRemouldStoneDropItemData selectStoneData;

	private bool IsSelect => false;

	private void Init()
	{
	}

	public void Refresh(NewPlay126MonsterRemouldStoneDropItemData stoneData, NewPlay126MonsterRemouldStoneDropItemData selectStoneData)
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickSelectBtn()
	{
	}
}

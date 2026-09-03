using UnityEngine;
using UnityEngine.UI;

public class NewPlay126RemouldStoneItem : MonoBehaviour
{
	[SerializeField]
	private Image stoneIcon;

	[SerializeField]
	private Image stoneQuality;

	[SerializeField]
	private GameObject selectStatus;

	[SerializeField]
	private GameObject unSelectStatus;

	[SerializeField]
	private ButtonCtrl setStoneBtn;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	private bool isInit;

	private int curStoneIndex;

	private NewPlay126MonsterRemouldStoneDropItemData curStoneData;

	private bool IsSetStone => false;

	private void Init()
	{
	}

	public void Refresh(NewPlay126MonsterRemouldStoneDropItemData curStoneData, int curStoneIndex)
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickSetStoneBtn()
	{
	}
}

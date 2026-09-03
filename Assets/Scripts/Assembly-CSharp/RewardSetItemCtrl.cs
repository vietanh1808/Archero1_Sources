using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class RewardSetItemCtrl : MonoBehaviour
{
	private enum ItemState
	{
		Undone = 0,
		Done = 1,
		Received = 2
	}

	public enum ItemType
	{
		Activity = 0,
		CheckIn = 1
	}

	[SerializeField]
	private Transform contentRoot;

	[SerializeField]
	private ButtonCtrl btnReceive;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtUndone;

	[SerializeField]
	private DxxText txtBtnReceive;

	[SerializeField]
	private DxxText txtProgress;

	[SerializeField]
	private GameObject goBtnReceive;

	[SerializeField]
	private GameObject goTxtUndone;

	[SerializeField]
	private GameObject goTxtProgress;

	[SerializeField]
	private GameObject goImgReceived;

	[SerializeField]
	private GameObject goShadow;

	private List<RewardItemCtrl> _rewardItemCtrls;

	private Drop_DropModel.DropData[] rewardData;

	private uint need;

	private int index;

	private LocalUnityObjctPool _pool;

	private ItemType type;

	private List<GameObject> list;

	private List<Drop_DropModel.DropData> rewardDataList => null;

	private string sourceName => null;

	private void Awake()
	{
	}

	private void OnBtnClick()
	{
	}

	public void UpdateUI(int i, LocalUnityObjctPool pool, ItemType t)
	{
	}

	private void UpdateRewards()
	{
	}

	private bool BuildRewardsData()
	{
		return false;
	}

	private int[][] GetReward(string rewardString)
	{
		return null;
	}

	private void UpdateState()
	{
	}
}

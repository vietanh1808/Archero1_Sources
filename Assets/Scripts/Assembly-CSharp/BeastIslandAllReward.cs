using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeastIslandAllReward : MonoBehaviour
{
	[SerializeField]
	private BeastIslandAllRewardItem rewardItem;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private DxxText curProgress;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private HorizontalLayoutGroup horizontalLayoutGroup;

	[SerializeField]
	private GameObject arrow;

	[SerializeField]
	private RectTransform progressBg;

	private List<BeastIslandAllRewardItem> rewardItemList;

	private LocalUnityObjctPool pool;

	private BeastIslandAllRewardData Act5thTorchAllRewardData => null;

	private int PreviewItemCount => 0;

	private float ProgressMaxWidth => 0f;

	private int AllProgressMaxScore => 0;

	private void InitObjectPool()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshAll(int progressValue)
	{
	}

	private void Refresh(int progressValue)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshProgress(int progressValue)
	{
	}

	private void RefreshText(int progressValue)
	{
	}

	private void RefreshScroll()
	{
	}

	private void RefreshStatus()
	{
	}

	public void RefreshArrowStatus(Vector2 value)
	{
	}

	private int GetPreviewItemCount()
	{
		return 0;
	}

	private float GetProgressMaxWidth()
	{
		return 0f;
	}

	private float GetProgressOriginWidth()
	{
		return 0f;
	}

	private int GetAllProgressMaxScore()
	{
		return 0;
	}
}

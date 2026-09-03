using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class HolyLightAllRewardPart : MonoBehaviour
{
	[SerializeField]
	private HolyLightAllRewardItem rewardItem;

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

	[SerializeField]
	private DxxText curLevel;

	public Action<Vector3, int> onClickSkill;

	private List<HolyLightAllRewardItem> rewardItemList;

	private LocalUnityObjctPool pool;

	private HolyLightAllRewardData HolyLightAllRewardData => null;

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

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshProgress()
	{
	}

	private void RefreshText()
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

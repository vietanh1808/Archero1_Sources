using System.Collections.Generic;
using UnityEngine;

public class Act5CheckInItem : MonoBehaviour
{
	public DxxText nameTex;

	public DxxText TimeDownTex;

	public DxxText getBtnTex;

	public GameObject hasGetObj;

	public GameObject rewardCopyObj;

	public GameObject mask;

	public RectTransform rewardParent;

	public ButtonCtrl getBtn;

	private List<GameObject> rewards;

	private Act5CheckInItemData mData;

	public void Init(Act5CheckInItemData data)
	{
	}

	public void RefreshState()
	{
	}

	public void InitRewards()
	{
	}

	public bool isMatch(uint type, uint id)
	{
		return false;
	}

	public void ClickGet()
	{
	}

	public Act5CheckInItemData GetData()
	{
		return null;
	}
}

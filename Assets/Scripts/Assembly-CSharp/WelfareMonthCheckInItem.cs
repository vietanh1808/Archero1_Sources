using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class WelfareMonthCheckInItem : MonoBehaviour
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

	private STActivityCrazyTask mData;

	public void Init(STActivityCrazyTask data)
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

	public STActivityCrazyTask GetData()
	{
		return null;
	}
}

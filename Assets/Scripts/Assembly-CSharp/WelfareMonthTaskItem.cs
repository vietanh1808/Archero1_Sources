using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class WelfareMonthTaskItem : MonoBehaviour
{
	public Image bgImage;

	public Image titleImage;

	public Color normalColor;

	public Color canReviceColor;

	public DxxText nameTex;

	public DxxText progressTex;

	public DxxText hasEndTex;

	public DxxText getBtnTex;

	public DxxText goBtnTex;

	public GameObject hasGetObj;

	public GameObject rewardCopyObj;

	public GameObject mask;

	public RectTransform rewardParent;

	public ButtonCtrl getBtn;

	public ButtonCtrl goBtn;

	[SerializeField]
	private ScrollRect scrollRect;

	private List<GameObject> rewards;

	private STActivityCrazyTask mData;

	private uint mType;

	public void Init(STActivityCrazyTask data, uint type)
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

	public void ClickGo()
	{
	}

	public STActivityCrazyTask GetData()
	{
		return null;
	}
}

using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class NobilityItemCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText mTextRank;

	[SerializeField]
	private Image mImgCup;

	[SerializeField]
	private DxxText mTextCupRank;

	[SerializeField]
	private Image mImgLeader;

	[SerializeField]
	private Image mImgHead;

	[SerializeField]
	private Image mImgHeadFrame;

	[SerializeField]
	private DxxText mTextName;

	[SerializeField]
	private DxxText mTextNobility;

	[SerializeField]
	private DxxText mTextHonor;

	[SerializeField]
	private Image mImgVip;

	[SerializeField]
	private DxxText mTextVip;

	[SerializeField]
	private ButtonCtrl mBtnPlayer;

	private GameObject _headFrameEffect;

	private RectTransform _scrollViewRect;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(CCampRank data, RectTransform scrollRect = null)
	{
	}

	private void Update()
	{
	}
}

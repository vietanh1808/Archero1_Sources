using GameProtocol;
using UnityEngine;
using XLua;

public class RewardPreviewPanel : MonoBehaviour
{
	[SerializeField]
	private RewardPreviewItemCtrl CopyOne;

	[SerializeField]
	private ButtonCtrl mCloseBtn;

	[SerializeField]
	private RectTransform mContent;

	[SerializeField]
	private DxxText mTextTitle;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool mPropOnePool;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(STRespActivityCommonTurn actData)
	{
	}
}

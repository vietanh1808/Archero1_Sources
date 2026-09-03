using UnityEngine;

public class AltarReclicsUpSecondTipsItem : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtBtnGo;

	[SerializeField]
	private DxxText txtCrtLv;

	[SerializeField]
	private DxxText txtTargetLv;

	[SerializeField]
	private ButtonCtrl btnGo;

	[SerializeField]
	private GameObject goStar;

	[SerializeField]
	private GameObject goAssist;

	[SerializeField]
	private DxxImage starTemplate;

	[SerializeField]
	private RectTransform crtStarParent;

	[SerializeField]
	private RectTransform targetStarParent;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	public void onInit(AltarSecondItemType type, int crtValue, int targetValue, int charID)
	{
	}
}

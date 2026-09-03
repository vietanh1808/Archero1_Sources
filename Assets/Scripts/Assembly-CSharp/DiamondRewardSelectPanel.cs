using TableTool;
using UnityEngine;

public class DiamondRewardSelectPanel : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private ButtonCtrl btn_confirm;

	[SerializeField]
	private DiamondRewardSelectItem template;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private PropOneEquip propAni;

	[SerializeField]
	private RectTransform rtContent;

	[SerializeField]
	private ActDiamondChoiceUICtrl ctrl;

	[SerializeField]
	private DxxText txt_Confirm;

	[SerializeField]
	private DxxText txt_title;

	[SerializeField]
	private DxxText txt_Desc;

	[SerializeField]
	private DxxText txt_propName;

	[SerializeField]
	private ScrollRectBase scroll;

	private LocalUnityObjctPool pool;

	private SelectKey crtKey;

	private bool tweening;

	private int selectIndex;

	private int crtIndex;

	private void Awake()
	{
	}

	public void OpenPanel(SelectKey key)
	{
	}

	public void RefreshPanel(SelectKey key)
	{
	}

	public void SetDescText(Drop_DropModel.DropData data)
	{
	}

	public void SelectIndex(int index, Transform trans)
	{
	}
}

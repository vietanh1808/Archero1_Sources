using UnityEngine;
using UnityEngine.UI;

public class BeliefTips : MonoBehaviour
{
	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_NeedCount;

	[SerializeField]
	private DxxText text_Content;

	[SerializeField]
	private DxxText text_Status;

	[SerializeField]
	private ButtonCtrl btn_UpGrade;

	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private ContentSizeFitter content_SF;

	[SerializeField]
	private RectTransform rect_Bg;

	private BeliefSkillItemData crtData;

	private string lockColor;

	private string unlockColor => null;

	private void Awake()
	{
	}

	public void Init(BeliefSkillItemData data)
	{
	}

	private void RefreshLayout()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnUpgradeBtnClick()
	{
	}
}

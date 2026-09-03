using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay126SkillItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image skillFillMask;

	[SerializeField]
	private Image skillIcon;

	[SerializeField]
	private GameObject skillLeftTip;

	[SerializeField]
	private GameObject skillRightTip;

	[SerializeField]
	private DxxText skillLeftTipTitle;

	[SerializeField]
	private DxxText skillRightTipTitle;

	[SerializeField]
	private DxxText skillLeftTipDesc;

	[SerializeField]
	private DxxText skillRightTipDesc;

	[SerializeField]
	private ButtonCtrl skillLeftTipMaskBtn;

	[SerializeField]
	private ButtonCtrl skillRightTipMaskBtn;

	private NewPlay126SkillItemData skillItemData;

	private bool isInit;

	private float clickDownTime;

	private bool isRight;

	private GameObject SkillTip => null;

	private bool NeedShowTip => false;

	private void Init()
	{
	}

	public void Refresh(NewPlay126SkillItemData skillItemData, bool isRight)
	{
	}

	public void RefreshStatus()
	{
	}

	private void RefreshProgress()
	{
	}

	private void RefreshShowTip()
	{
	}

	private void Update()
	{
	}

	private void OnClickBtn()
	{
	}

	private void OnClickBtnDown()
	{
	}

	private void OnClickBtnUp()
	{
	}

	private void ClickSkillTipMaskBtn()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;

public class TridentSkillBtnCtrl : MonoBehaviour
{
	private string Tag;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private GameObject TridentIcon;

	[SerializeField]
	private GameObject DaggerIcon;

	[SerializeField]
	private Image TridentMask;

	[SerializeField]
	private Image SliderBlue;

	[SerializeField]
	private Image SliderGold;

	[SerializeField]
	private Image SliderSuperGold;

	[SerializeField]
	private Image SliderRed;

	[SerializeField]
	private GameObject EffHead;

	[SerializeField]
	private GameObject FullEff;

	private bool isUsingDagger;

	private bool isInit;

	public float switchCd;

	private float preSwichTime;

	private const float thresholdColor1 = 0.3f;

	private const float thresholdColor2 = 0.6f;

	private bool isFirstCd;

	private float showRate;

	private void Init()
	{
	}

	public void Refresh(bool isDagger)
	{
	}

	private void RefreshStatus()
	{
	}

	private void OnTridentChangeState(bool isDagger)
	{
	}

	private void UpdateDivinityUIShow(float curValue, float limit)
	{
	}

	private void UpdateBtnEnable(bool isEnabled)
	{
	}

	private void UpdateCrystalFx()
	{
	}

	private void ClickLanceSkillBtn()
	{
	}

	public void DeInit()
	{
	}

	private void OnUpdate(float delta)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;

public class LanceSkillBtnCtrl : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image fillIcon;

	[SerializeField]
	private LanceCrystalCtrl crystalCtrl;

	[SerializeField]
	private GameObject LanceLight;

	[SerializeField]
	private GameObject LanceDark;

	[SerializeField]
	private GameObject Cannon;

	private bool isCannon;

	private bool isInit;

	private float maxIconValue;

	public float threshold;

	private void Init()
	{
	}

	public void Refresh(bool isCanon)
	{
	}

	private void RefreshStatus()
	{
	}

	private void OnLanceChangeState(bool isCannon)
	{
	}

	private void UpdateDarkEnergyUIShow(float curValue, float limit)
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
}

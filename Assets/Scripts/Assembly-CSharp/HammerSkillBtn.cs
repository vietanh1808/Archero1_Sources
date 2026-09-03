using UnityEngine;
using UnityEngine.UI;

public class HammerSkillBtn : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image maskIcon;

	[SerializeField]
	private Image fillIcon;

	private bool isThunder;

	private bool isInit;

	private float maxIconValue;

	private Color color1;

	private Color color2;

	private Color color3;

	private void Init()
	{
	}

	public void Refresh(bool isThunder)
	{
	}

	private void RefreshStatus()
	{
	}

	private void OnHammerChangeState(bool isThunder)
	{
	}

	private void UpdateBtnIcon()
	{
	}

	private void UpdateThunderValue(int curValue)
	{
	}

	private void UpdateBtnEnable(bool isEnabled)
	{
	}

	private void ClickHammerSkillBtn()
	{
	}

	public void Close()
	{
	}

	private Color GetColor(int curValue, int needValue, int maxValue)
	{
		return default;
	}
}

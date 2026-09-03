using UnityEngine.UI;

public class CDButton
{
	public ButtonCtrl btn_dragon;

	public Image timer;

	public Image skillIcon;

	public DxxText txt_timer;

	public bool IsVisible;

	private DragonMagicInGameCtrlVO dragonUIVO;

	private DragonType dragonType;

	private DragonVO dragonVO;

	private bool isBtnDragonEnabled => false;

	private bool hasNoCDTime => false;

	private bool isMagicValueEnough => false;

	public void SetActive(bool active)
	{
	}

	public void Init(DragonMagicInGameCtrlVO _dragonUIVO, DragonVO _dragonVO)
	{
	}

	public DragonVO GetDragonVO()
	{
		return null;
	}

	public void RefreshUI(bool refreshSkillIcon = false)
	{
	}

	public void RefreshBtnDragon()
	{
	}

	public void RefreshSkillIcon()
	{
	}

	public void RefreshTimer()
	{
	}

	public void OnTimer()
	{
	}

	public void RefreshTimer(float remainTime)
	{
	}
}

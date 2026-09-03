using HabbySdk.HabbyId;
using UnityEngine;
using UnityEngine.UI;

public class HID_IconAnim : HIDUIBase
{
	public Image writeBg;

	public Image loginIcon;

	public Image registerIcon;

	public Image reductionIcon;

	public Image verifyIcon;

	private Color transparentColor;

	private Color normalColor;

	public void ShowByState(ProcessType t)
	{
	}

	public void Hide()
	{
	}

	public void ShowLogoAnim(LogoType logoType, bool isLeftShow)
	{
	}

	public void HideLogoAnim(LogoType logoType, bool isLeftHide)
	{
	}

	private Image GetImage(LogoType logoType)
	{
		return null;
	}
}

using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LayoutElement))]
public class DragonMagicSkillProperty : MonoBehaviour
{
	[SerializeField]
	private DxxText txtProperty;

	[SerializeField]
	private DxxText txtUnlockLevel;

	[SerializeField]
	private Sprite[] sprites;

	[SerializeField]
	private DxxImage img;

	private int index;

	private DragonMagic_MagicConfig config;

	private float total;

	private string tid;

	private int unlockLevel;

	private bool levelMax;

	private bool unlocked;

	private float deltaByLevel;

	private bool hideDelta => false;

	private string deltaStr => null;

	private string deltaStrArabic => null;

	private string deltaStrPercent => null;

	private string deltaStrPercentArabic => null;

	private string totalStrPercent => null;

	private string totalStrPercentArabic => null;

	private string totalStr => null;

	private string totalStrArabic => null;

	public void SetProperty(int skillLevel, bool unlocked, DragonMagic_MagicConfig skillConfig, int skillIndex)
	{
	}

	private void SetText()
	{
	}

	private string GetTextPropertyPercentArabic()
	{
		return null;
	}

	private string GetTextPropertyPercent()
	{
		return null;
	}

	private string GetTextProperty()
	{
		return null;
	}

	private string GetTextPropertyArabic()
	{
		return null;
	}

	public void GetUpgradeTween(Sequence seq, int newLevel)
	{
	}
}

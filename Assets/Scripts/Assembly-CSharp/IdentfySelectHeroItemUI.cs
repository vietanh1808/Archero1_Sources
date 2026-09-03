using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class IdentfySelectHeroItemUI : MonoBehaviour
{
	public Image headIcon;

	public ButtonCtrl selectBtn;

	public Text btnText;

	public Text nameText;

	public Text effectText;

	public Text notHaveText;

	public RectTransform rightObject;

	public Image lockImg;

	public Image selectedImg;

	public CharStarShowItem starItem;

	public int Index { get; private set; }

	public PlayerCharacter_Character config { get; private set; }

	public void Init(int pIndex, PlayerCharacter_Character pConfig)
	{
	}

	private void InitInfo()
	{
	}

	private void InitStar()
	{
	}

	public void RestUI()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void RefLanguage()
	{
	}

	private void OnClickSelect()
	{
	}
}

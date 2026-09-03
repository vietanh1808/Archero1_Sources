using System;
using TableTool;

public class HeroEnhanceView : EnhanceScrollView
{
	private PlayerCharacter_Character m_data;

	private Action<int, PlayerCharacter_Skin> SelectedCallback;

	public ButtonCtrl btnLeftSkin;

	public ButtonCtrl btnRightSkin;

	public ButtonCtrl btnSkin;

	public DxxText textBtnSkin;

	public int DataLength => 0;

	public void Init(Action<int, PlayerCharacter_Skin> selectedCallback)
	{
	}

	public void UpdateView(PlayerCharacter_Character data, int startIndex = 0)
	{
	}

	protected override void OnSelectedItem(object data, int index)
	{
	}

	protected void UpdateArrows(int index)
	{
	}

	public void OnLanguageChange()
	{
	}
}

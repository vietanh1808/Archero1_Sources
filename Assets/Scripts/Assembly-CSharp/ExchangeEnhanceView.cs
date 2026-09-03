using System;
using TableTool;

public class ExchangeEnhanceView : EnhanceScrollView
{
	private PlayerCharacter_Character m_data;

	private Action<int, PlayerCharacter_Skin> SelectedCallback;

	public void Init(Action<int, PlayerCharacter_Skin> selectedCallback)
	{
	}

	public void UpdateView(PlayerCharacter_Character data, int startIndex = 0)
	{
	}

	protected override void OnSelectedItem(object data, int index)
	{
	}

	protected override void OnClose()
	{
	}
}

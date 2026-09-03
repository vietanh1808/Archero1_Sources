using System;
using UnityEngine.UI;

public class BottomBarButton : ButtonCtrl
{
	public Image icon;

	public DxxText SkinName;

	public Image selected;

	private Action<int, BottomBarButton> OnClickBtn;

	public int Id { get; private set; }

	public void Init(int id, Action<int, BottomBarButton> OnClickBtn)
	{
	}

	public void UpdateData(int id)
	{
	}

	private void OnClickButton()
	{
	}

	public bool IsLearnOver()
	{
		return false;
	}
}

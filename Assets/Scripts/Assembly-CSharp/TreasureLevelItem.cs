using System;
using UnityEngine;
using UnityEngine.UI;

public class TreasureLevelItem : ViewCell
{
	public Image iconImage;

	public DxxText levelText;

	public ButtonCtrl btn;

	public GameObject selectedMark;

	public Sprite activatedSprite;

	public Sprite inactiveSprite;

	public Sprite CurSprite;

	public Action<int> onSelect;

	protected override void OnInit()
	{
	}

	protected override void OnRefresh()
	{
	}
}

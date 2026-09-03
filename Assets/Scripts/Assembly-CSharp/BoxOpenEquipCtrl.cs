using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BoxOpenEquipCtrl : MonoBehaviour
{
	public enum State
	{
		eBack = 0,
		eFront = 1
	}

	public DxxImage Image_BG;

	public Image Image_Circle;

	public DxxImage Image_Icon;

	public DxxImage Image_Type;

	public DxxText Text_Count;

	public GameObject effect_chargeparent;

	public GameObject effect_frontparent;

	public DxxText Gem_Level;

	private Dictionary<int, UISortOrder> effect_charges;

	private Dictionary<int, UISortOrder> effect_fronts;

	private State mState;

	public Drop_DropModel.DropData mData;

	private RectTransform _t;

	private GameObject dragonRarity;

	public RectTransform mTransform => null;

	public void SetEquip(Drop_DropModel.DropData data)
	{
	}

	public void SetState(State state)
	{
	}

	public void show_effect_charge(bool value)
	{
	}

	public void show_effect_front(bool value)
	{
	}

	public void Show()
	{
	}
}

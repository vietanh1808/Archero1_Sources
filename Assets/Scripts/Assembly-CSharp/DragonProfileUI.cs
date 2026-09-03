using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class DragonProfileUI : MonoBehaviour
{
	public DxxText txt_unlock_condition;

	public DxxText txt_add;

	public HorizontalLayoutGroup lvLayoutGroup;

	public Image img_rarity;

	public GameObject goLevelUpRedDot;

	public Image image_circle;

	public DxxText txt_level;

	public GameObject baseEffect;

	public ButtonCtrl btn_dragon;

	public GameObject profile_container;

	public Image image_dragon_base;

	public Image image_head;

	public DxxText txt_quality;

	public Image image_skill_0;

	public Image image_skill_1;

	public Image image_skill_2;

	public Image image_skill_3;

	public GameObject goSwitch;

	private bool isSwitching;

	[HideInInspector]
	public List<Image> image_skill_list;

	[HideInInspector]
	public int SlotIndex;

	private LocalSave.EquipOne equipOne;

	public bool isUnlocked => false;

	public bool HasDragon => false;

	public LocalSave.EquipOne DragonOne => null;

	public void Awake()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void SetData(LocalSave.EquipOne _equipOne)
	{
	}

	public void OnInit()
	{
	}

	public void OnDeInit()
	{
	}

	public void ShowSwitching(bool active)
	{
	}

	private void onClickDragon()
	{
	}

	protected void OnSetArgs(object o)
	{
	}

	public void OnOpen()
	{
	}

	protected void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void makeBaseInvisible()
	{
	}

	public void refreshUI()
	{
	}

	private void refresh_image_skills()
	{
	}

	private void refresh_txt_quality()
	{
	}
}

using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MonsterBookItem : MonoBehaviour
{
	public GameObject Bottom;

	public GameObject Loader;

	public ButtonCtrl Button_Unlock;

	public Image Image_Locker;

	public DxxText Text_Diamond;

	public DxxText Text_Unlock;

	[HideInInspector]
	public MonsterIcon monsterIcon;

	private int state;

	public DOTweenAnimation child_ani;

	public int Location;

	public GameObject DiamondNode;

	public Image Image_VIP;

	public DxxText Text_VIP;

	public void init(int location)
	{
	}

	public void OnButtonItem()
	{
	}

	public bool isUnlock()
	{
		return false;
	}

	public void buySuccess()
	{
	}

	private void freshItem()
	{
	}

	public void addBattle(LocalSave.MonsterData data)
	{
	}

	public void removeBattle()
	{
	}

	public void freshStarUP(LocalSave.MonsterData data, MonsterIcon.TabName name)
	{
	}

	public void changeState(int state)
	{
	}

	private void clickStateCallback()
	{
	}
}

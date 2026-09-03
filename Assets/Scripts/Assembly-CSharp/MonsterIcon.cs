using System;
using UnityEngine;
using UnityEngine.UI;

public class MonsterIcon : MonoBehaviour
{
	public enum TabName
	{
		Unknown = 0,
		Farm = 1,
		Book = 2
	}

	public Image Image_MeadowBattleFlag;

	public Slider slider;

	public DxxText Text_Star;

	public DxxText Text_Progress;

	public Image Image_Icon;

	public Image Image_Monster;

	public Image Image_Star;

	public ButtonCtrl button;

	public GameObject top;

	public Material Mat_Gray;

	public Image Image_ArrowUP;

	public Image Slider_Progress;

	public DxxText Text_Locker;

	private int monsterid;

	public Action clickStateAction;

	private LocalSave.MonsterData data;

	private TabName tabName;

	public void init(LocalSave.MonsterData data, TabName name)
	{
	}

	private void initMeadowBattleFlag(int monsterId)
	{
	}

	public void onButtonOpenAttr()
	{
	}

	public void onButtonGo()
	{
	}

	public LocalSave.MonsterData getMonsterData()
	{
		return null;
	}

	public void setClickAction(Action action)
	{
	}
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonMagicInGameCtrl : MonoBehaviour
{
	private DragonMagicInGameCtrlVO dragonUIVO;

	public DragonMagicBarCtrl barCtrl;

	public Dictionary<int, DragonVO> DragonVODict;

	public Dictionary<DragonType, CDButton> CDButtonDict;

	private int DragonCount;

	private List<CDButton> cdBtnList;

	public ButtonCtrl btn_dragon_1;

	public ButtonCtrl btn_dragon_2;

	public ButtonCtrl btn_dragon_3;

	public ButtonCtrl btn_dragon_4;

	public ButtonCtrl btn_dragon_5;

	public ButtonCtrl btn_dragon_6;

	public Image timer1;

	public Image timer2;

	public Image timer3;

	public Image timer4;

	public Image timer5;

	public Image timer6;

	public DxxText txt_timer1;

	public DxxText txt_timer3;

	public DxxText txt_timer2;

	public DxxText txt_timer4;

	public DxxText txt_timer5;

	public DxxText txt_timer6;

	public Image image_skill_1;

	public Image image_skill_2;

	public Image image_skill_3;

	public Image image_skill_4;

	public Image image_skill_5;

	public Image image_skill_6;

	public DxxText txt_cur_mp;

	public DxxText txt_max_mp;

	public void Awake()
	{
	}

	public void Init()
	{
	}

	private void onClickDragon6()
	{
	}

	private void onClickDragon5()
	{
	}

	private void onClickDragon4()
	{
	}

	private void onColdTimePercentUpdate()
	{
	}

	public void StartTimer()
	{
	}

	public void StopTimer()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onMPMaxUpdate(long oldMagicValue)
	{
	}

	public void DeInit()
	{
	}

	private void initDragonUIVO()
	{
	}

	private void onMagicValueChanged()
	{
	}

	private void refreshAllCDBtns()
	{
	}

	private void onCDTimeChanged(DragonType dragonType)
	{
	}

	public void AddDragonVO(DragonVO vo)
	{
	}

	private void onClickDragon1()
	{
	}

	private void onClickDragon2()
	{
	}

	private void onClickDragon3()
	{
	}

	private void tryAddDragon(CDButton cdBtn)
	{
	}

	private void SetDragonCallCount(DragonType type)
	{
	}

	public void UpdateCurMagicValue(int deltaValue)
	{
	}

	public void InitCurMagicValue(int value)
	{
	}

	private CDButton createNewCDButton(ButtonCtrl btn_dragon_1, DxxText txt_timer1, Image timer1, Image skillIcon)
	{
		return null;
	}

	public void SetTxtMpVisible_DEBUG(bool show)
	{
	}

	public void AddMp_DEBUG(int deltaMp)
	{
	}
}

using UnityEngine;
using UnityEngine.UI;
using homepage;

public class PlayerHomePageCtrl : MonoBehaviour
{
	public HomePageCharUICtrl CharUICtrl;

	public Image stage_Icon;

	public DxxText txt_stage;

	public DxxText txt_hero;

	public DxxText txt_monster;

	public ButtonCtrl btn_stage;

	public ButtonCtrl btn_hero;

	public ButtonCtrl btn_monster;

	public PetShowItem petShow;

	public ImprintLevelShowItem imprintItem;

	public DxxText txt_tip;

	public DxxText txt_showing;

	public DxxText label_switch;

	public Image image_switch;

	public ButtonCtrl btn_switch;

	public GameObject hideObj;

	public GameObject showObj;

	public DxxText txt_card;

	private LocalHeroVO heroVO;

	public void OnLanguageChange()
	{
	}

	private void setNameCardVisible(bool visible)
	{
	}

	public void OnInit()
	{
	}

	public void OnClose()
	{
	}

	private void update_txt_showing(bool showAnim)
	{
	}

	public void OnOpen()
	{
	}

	private void onNameCardAvailable(bool showAnim = false)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void freshStageInfo()
	{
	}
}

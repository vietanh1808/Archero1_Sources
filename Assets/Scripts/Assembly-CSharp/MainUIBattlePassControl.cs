using UnityEngine;
using UnityEngine.UI;

public class MainUIBattlePassControl : MonoBehaviour
{
	public Slider m_slider;

	public DxxText textLevel;

	public ButtonCtrl buttonOpenBattlePass;

	public UISliderTween tween;

	public Animation anim;

	public DxxText textKillCount;

	public DxxText textSeason;

	public GameObject notice;

	public static bool isNew;

	public void OnOpen()
	{
	}

	private void LoopEnd()
	{
	}

	private void OnTweenEnd()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnClickOpen()
	{
	}
}

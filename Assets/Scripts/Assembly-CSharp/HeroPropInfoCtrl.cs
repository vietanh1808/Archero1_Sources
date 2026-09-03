using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HeroPropInfoCtrl : MonoBehaviour
{
	public enum PropType
	{
		ATK = 0,
		HP = 1,
		Per = 2,
		Level = 3,
		ATKHero = 4,
		HPHero = 5
	}

	public static readonly List<string> PropLanguageID;

	public static readonly List<string> PropIconPath;

	public PropType CurrentPropType;

	public Text PropTypeText;

	public Text PropValueText;

	public Image PropSprite;

	public RectTransform PropContent;

	private string propTypeStr;

	public int propValue;

	public int propValueMax;

	private bool ifShowDelta;

	private int propDelta;

	public Animator UpgradeAnim;

	private Sequence upgradeSeq;

	public void SetPropType(PropType pt)
	{
	}

	public void SetValue(int value, int max, bool showDelta = false, int deltaVal = 0)
	{
	}

	public void PlayToTarget(int target, float delayTime = 0f, UnityAction action = null)
	{
	}

	public void PlayToTarget(int begin, int target, float delayTime = 0f, UnityAction action = null)
	{
	}

	public void PlayUpgradeAnim()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshUI()
	{
	}

	private void OnDestroy()
	{
	}
}

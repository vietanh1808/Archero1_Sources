using System;
using System.Collections.Generic;
using UnityEngine;

public class HolyLightDetailsPanel : MonoBehaviour
{
	public DxxText titleText;

	public DxxText levelText;

	public DxxText attributeText;

	public DxxText skillText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public RectTransform skillItemParent;

	public RectTransform bgTrans;

	public HolyLightDetailsSkillItem detailsSkillItem;

	private List<HolyLightDetailsSkillItem> detailsSkillItems;

	public Action<Vector3, int> onClickSkill;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private float GetCurLevelRate(string[] configs, int level)
	{
		return 0f;
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}
}

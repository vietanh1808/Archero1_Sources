using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuidBossPanel : MonoBehaviour
{
	[SerializeField]
	private float leftX;

	[SerializeField]
	private float rightX;

	[SerializeField]
	private float upY;

	[SerializeField]
	private float downY;

	public RectTransform rectTran;

	private Vector3 bossPoint;

	private CampMapManager campInstance;

	[SerializeField]
	private RectTransform guid_Boss;

	[SerializeField]
	private RectTransform guid_Line_Build;

	[SerializeField]
	private RectTransform guid_Row_Build;

	[SerializeField]
	private RectTransform guide_box;

	[SerializeField]
	private RectTransform guide_town;

	[SerializeField]
	private RectTransform guide_marked;

	[SerializeField]
	private RectTransform guide_campbox;

	[SerializeField]
	private RectTransform arrow_Boss;

	[SerializeField]
	private RectTransform arrow_Line_Build;

	[SerializeField]
	private RectTransform arrow_Row_Build;

	[SerializeField]
	private RectTransform guide_box_arrow;

	[SerializeField]
	private RectTransform guide_town_arrow;

	[SerializeField]
	private RectTransform guide_marked_arrow;

	[SerializeField]
	private RectTransform guide_campbox_arrow;

	public Image Image_Town;

	private Vector3 TownPoint;

	private List<HolyLandData> holyLands;

	private Vector3 RewardBoxPoint;

	private bool isHaveRewardBoxOnce;

	private Vector3 PointMarked;

	private bool isHavePointMarked;

	private Vector3 PointCampBox;

	private bool isHavePointCampBox;

	private Vector3 HolyLinePoint;

	private Vector3 HolyRowPoint;

	private bool isNeedGuideBoss;

	private void Start()
	{
	}

	public void init()
	{
	}

	private void Update()
	{
	}

	public void IsGuid()
	{
	}

	public void GuidBoss()
	{
	}

	public void GuidHolyLand()
	{
	}

	private void GuideBoxRewardOnce()
	{
	}

	private void GuideTown()
	{
	}

	private void GuidePointMarked()
	{
	}

	private void GuidePointCampBox()
	{
	}

	public void GuidTarget(RectTransform guid, RectTransform arrow, Vector3 target)
	{
	}

	public void onButtonBoss()
	{
	}

	public void onButtonHolyLine()
	{
	}

	public void onButtonHolyRow()
	{
	}

	public void onButtonRewardBox()
	{
	}

	public void onButtonTown()
	{
	}

	public void onButtonGoMark()
	{
	}

	public void onButtonGoCampBox()
	{
	}
}

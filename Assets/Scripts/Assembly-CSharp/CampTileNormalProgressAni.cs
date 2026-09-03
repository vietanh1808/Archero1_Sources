using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CampTileNormalProgressAni : MonoBehaviour
{
	[SerializeField]
	private Animator ani;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private CampTileNumFlyAni NumFlyAni;

	[SerializeField]
	private Transform flyNumParent;

	private List<CampTileNumFlyAni> allFNumFlyAni;

	private Tweener aniProgressWidth;

	private Tweener aniNumRoll;

	private float targetAddWidth;

	private int targetScore;

	private int curScore;

	private int maxScore;

	private CampTileArrowDamageData damageData;

	private Sequence sequence;

	private CampID recordOccupyCamp;

	private CampTileOccupyType occupyType;

	private bool isAbbreviatedNumRollAni;

	public void Init()
	{
	}

	public Sequence PlayAni(int curScore, int maxScore, float progressOriginWidth, CampTileArrowDamageData damageData, CampID recordOccupyCamp, CampTileOccupyType occupyType, bool isAbbreviatedNumRollAni)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public void ResetAni()
	{
	}

	public Tweener PlayProgressAni()
	{
		return null;
	}

	public void StopProgressAni()
	{
	}

	public Tweener PlayProgressNumRollAni()
	{
		return null;
	}

	public void StopProgressNumRollAni()
	{
	}

	public void UpdateRollNumber(int rollNum)
	{
	}

	public void CompleteRollNumber()
	{
	}

	public Tweener PlayProgressNumFlyAni()
	{
		return null;
	}

	public void StopProgressNumFlyAni()
	{
	}

	public void PlayLightAni()
	{
	}

	public void StopLightAni()
	{
	}
}

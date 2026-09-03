using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CampTileBattleProgressAni : MonoBehaviour
{
	[SerializeField]
	private Animator leftAni;

	[SerializeField]
	private Animator rightAni;

	[SerializeField]
	private RectTransform leftProgress;

	[SerializeField]
	private RectTransform rightProgress;

	[SerializeField]
	private DxxText leftProgressText;

	[SerializeField]
	private DxxText rightProgressText;

	[SerializeField]
	private Transform progressParent;

	[SerializeField]
	private CampTileNumFlyAni NumFlyAni;

	[SerializeField]
	private Transform flyNumParent;

	[SerializeField]
	private RectTransform battleIcon;

	private List<CampTileNumFlyAni> allFNumFlyAni;

	private Sequence aniProgressWidth;

	private Tweener aniNumRoll;

	private float leftTargetWidth;

	private float rightTargetWidth;

	private int targetScore;

	private int curScore;

	private int maxScore;

	private CampTileArrowDamageData damageData;

	private Sequence sequence;

	private bool isLeft;

	private float progressOriginWidth;

	private CampTileOccupyType occupyType;

	public void Init()
	{
	}

	public Sequence PlayAni(int curScore, int maxScore, float progressOriginWidth, CampTileArrowDamageData damageData, bool isLeft, CampTileOccupyType occupyType)
	{
		return null;
	}

	public void StopAni()
	{
	}

	public void ResetAni()
	{
	}

	public Sequence PlayProgressAni()
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

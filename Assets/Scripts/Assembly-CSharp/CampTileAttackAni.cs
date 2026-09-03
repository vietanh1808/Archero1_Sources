using System.Collections.Generic;
using DG.Tweening;
using GameProtocol;
using UnityEngine;

public class CampTileAttackAni : MonoBehaviour
{
	[SerializeField]
	private CampTileCurrency currency;

	[SerializeField]
	private CampTileOccupyBtn occupyBtn;

	[SerializeField]
	private CampTileProgress progress;

	[SerializeField]
	private RectTransform target;

	[SerializeField]
	private GameObject targetBeHitEffect;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private CampTileArrowAni arrowAni;

	private List<GameObject> hitEffect;

	private List<CampTileArrowAni> arrowItemList;

	private List<Sequence> arrowSequenceList;

	private Sequence sequence;

	private Tweener shake;

	private CRespCampBlock response;

	private int oldLevel;

	private List<CampTileArrowDamageData> damageData;

	private CampTileOccupyAttackType attackType;

	private HashSet<CampID> tilePosCamp;

	private int returnIronArrow;

	private int returnGoldArrow;

	private CampID recordOccupyCamp;

	private bool isAttackBossMonster;

	private CampTileMonsterProgressItem monsterProgressItem;

	public void Init()
	{
	}

	public void PlayAni(List<CampTileArrowDamageData> damageData, CRespCampBlock response, int oldLevel, CampTileOccupyAttackType attackType, HashSet<CampID> tilePosCamp, int returnIronArrow, int returnGoldArrow, CampID recordOccupyCamp)
	{
	}

	public void Play()
	{
	}

	public void Clear()
	{
	}

	public void ClearMonsterProgressItem()
	{
	}

	public void StopAni()
	{
	}

	public void CompleteAni()
	{
	}

	public Tweener PlayArrowAni(CampTileArrowType arrowType, Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	public void StopArrowAni()
	{
	}

	public Sequence PlayProgressAni(CampTileArrowDamageData data, CampID recordOccupyCamp)
	{
		return null;
	}

	public void StopProgressAni()
	{
	}

	public void PlayTargetHitAni()
	{
	}

	public void StopTargetHitAni()
	{
	}

	public Tweener PlayTargetShakeAni()
	{
		return null;
	}

	public void StopTargetShakeAni()
	{
	}

	public Sequence PlayArrowReturnAni()
	{
		return null;
	}

	public void StopArrowReturnAni()
	{
	}

	public void Click()
	{
	}

	public void PlayRewardAni()
	{
	}

	public void SetMonsterData(RectTransform target, CampTileMonsterProgressItem monsterProgressItem, int attackMonsterCampID)
	{
	}
}

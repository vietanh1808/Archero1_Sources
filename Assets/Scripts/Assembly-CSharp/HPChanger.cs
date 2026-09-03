using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPChanger : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	private static Dictionary<HitType, float> mTimes;

	private static Color Color_AttackSpeed;

	private Transform mTransform;

	private EntityBase m_Entity;

	private Vector3 entitypos;

	private Vector3 entitybodypos;

	private DxxText text;

	private float OffsetX;

	private float OffsetY;

	private Vector3 MovePer;

	private Vector3 MoveAll;

	private const int MoveCount = 14;

	private int CurrentMoveCount;

	private int FontSize;

	private float CritFontScale;

	private float HeadShotFontScale;

	private float SkinHeadShotFontScale;

	private const string Ani_Normal = "HPChanger_Normal";

	private const string Ani_Crit = "HPChanger_Crit";

	private const string Ani_HeadShot = "HPChanger_HeadShot";

	private float starttime;

	private CanvasGroup mCanvasGroup;

	private HitType mHitType;

	private AnimationCurve curve_pos;

	private AnimationCurve curve_scale;

	private AnimationCurve curve_alpha;

	private LanguageManager m_language;

	private bool isDualCrit;

	private Vector3 screens;

	private float percent;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void Despawn()
	{
	}

	public void Init(EntityBase entity, HitStruct hs)
	{
	}

	private void handleHitTypeByDragon(HitType mHitType)
	{
	}
}

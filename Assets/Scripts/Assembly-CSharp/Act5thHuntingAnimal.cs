using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingAnimal : Act5thHuntingEntity, IAct5thHuntingAnimal, IAct5thHuntingEntity
{
	[SerializeField]
	private CircleCollider2D circleCollider2D;

	[SerializeField]
	private Image animalIcon;

	[SerializeField]
	private Image animalQualityIcon;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Act5thHuntingDrop dropItem;

	[SerializeField]
	private Act5thHuntingAnimalAni animalAni;

	[SerializeField]
	private RectTransform headRect;

	[SerializeField]
	private RectTransform hpRect;

	[SerializeField]
	private RectTransform kingIconRect;

	private List<Act5thHuntingDrop> drops;

	private LocalUnityObjctPool pool;

	private Tweener fadeTween;

	private Tween delayCall;

	private Tweener shake;

	private Vector2 originPos;

	private float hpOriginWidth;

	private Vector2 originKingIconSize;

	private int animalWave;

	private Act5thHuntingAnimalData HuntingAnimalData { get; set; }

	private float Radius => 0f;

	protected override bool CanBeAttack => false;

	protected override Act5thHuntingEntityType EntityType => Act5thHuntingEntityType.None;

	private float Scale => 0f;

	private float HPWidth => 0f;

	private Vector2 CurMoveDir { get; set; }

	protected override void Init()
	{
	}

	public override void SetMoveRotate(float angle)
	{
	}

	public override Vector2 GetCurMoveDir()
	{
		return default;
	}

	protected override float GetReboundAngle(Vector2 wallVerticalDir)
	{
		return 0f;
	}

	public void SetAnimalWave(int animalWave)
	{
	}

	public void Refresh(Act5thHuntingAnimalData data)
	{
	}

	private void RefreshSize()
	{
	}

	private void RefreshHPProgress()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshPos()
	{
	}

	public float GetRadius()
	{
		return 0f;
	}

	public override void OnCollideEntity(int triggerHashCode, float dmg)
	{
	}

	protected override void OnAliveEnd()
	{
	}

	public override void OnRecycle()
	{
	}

	public override void OnRecycleImmediately()
	{
	}

	public override void OnClearData()
	{
	}
}

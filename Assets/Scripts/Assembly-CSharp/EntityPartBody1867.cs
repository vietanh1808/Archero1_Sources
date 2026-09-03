using Daily129;
using UnityEngine;

public class EntityPartBody1867 : EntityPartBodyBase
{
	[SerializeField]
	private Transform _goAttackRange;

	[SerializeField]
	private SpriteRenderer _spriteRendererQuality;

	[SerializeField]
	private GameObject _goGuide;

	[SerializeField]
	private Animation _animation;

	private GameObject _upgradeGuideEffect;

	private TowerModel _towerModel;

	public TowerModel TowerModel => null;

	public override string modelid => null;

	public override bool IgnorePartBodyShader => false;

	public bool HaveGuide => false;

	public override EntityBase m_HatredTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Init(int partId, TowerModel towerModel)
	{
	}

	public void SetAttackRange()
	{
	}

	protected override void OnCreateModel()
	{
	}

	public void ShowAttackRange(bool show)
	{
	}

	protected override bool CanPlayBirthCallEffect()
	{
		return false;
	}

	protected override bool CanPlayDisappearEffect()
	{
		return false;
	}

	public void ShowGuide(bool show)
	{
	}

	public void StopAnimation()
	{
	}

	public void PlayAnimation()
	{
	}

	public Transform GetGuideTransform()
	{
		return null;
	}

	public void ShowCanUpgradeEffect(bool show)
	{
	}
}

using System;
using UnityEngine;

public class ReleaseManager : MonoBehaviour
{
	private GameManager _Game;

	private EntityManager _Entity;

	private CoroutineHelper _coroutineHelper;

	private BulletManager _Bullet;

	private EffectManager _Effect;

	private MapEffectManager _MapEffect;

	private EntityCacheManager _EntityCache;

	private GameFormManager _Form;

	private MapCreator _MapCreator;

	private FindPath _Path;

	private GoodsCreateManager _GoodsCreate;

	private ReleaseModeManager _Mode;

	public ActionPortal PortalAction;

	public ActionCallSkullSlaves CallSkullAction;

	public Action OnReleaseModeManagerInit;

	public Action OnReleaseModeManagerDeInit;

	public Action<int> OnSkillLevelUpClosed;

	public GameManager Game => null;

	public EntityManager Entity => null;

	public CoroutineHelper coroutineHelper => null;

	public BulletManager Bullet => null;

	public EffectManager Effect => null;

	public MapEffectManager MapEffect => null;

	public EntityCacheManager EntityCache => null;

	public GameFormManager Form => null;

	public MapCreator MapCreatorCtrl => null;

	public FindPath Path => null;

	public GoodsCreateManager GoodsCreate => null;

	public ReleaseModeManager Mode => null;

	private void Awake()
	{
	}

	public void CampBattleRoundRelease()
	{
	}

	public void Release()
	{
	}

	public void ReleaseInternal()
	{
	}

	public void SetActionPortal(ActionPortal portalAction)
	{
	}

	public void ClearActionPortal()
	{
	}

	public void SetActionSkull(ActionCallSkullSlaves action)
	{
	}

	public void ClearActionSkull()
	{
	}
}

using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1953 : SkillAlone1952
{
	public class ShieldHammerCreator
	{
		private const string CREATOR_UPDATE_NAME = "ShieldHammerCreator-Update";

		public string ExternalTag;

		public EntityBase m_Entity;

		public float shieldHammerRadius;

		public int shieldHammerDebuff;

		public int shieldHammerCount;

		public float RotateSpeedPerFrame;

		public float shieldHammerAtkPercent;

		private RotateAroundAxis rotateShieldHammer;

		public bool isShieldHammerCreated;

		private float curRadius;

		private List<BulletBase> bullets;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void onOpenDoor(RoomGenerateBase.Room room)
		{
		}

		private void onGotoNextRoom(RoomGenerateBase.Room room)
		{
		}

		private void enableBullet(BulletBase bullet, bool isEnabled)
		{
		}

		private void onUpdate(float obj)
		{
		}

		private void onRotateSpeedUpdate(int obj)
		{
		}

		public void CreateShieldHammer()
		{
		}

		public void DestroyShieldHammer()
		{
		}

		private GameObject createShieldHammerContainer()
		{
			return null;
		}

		private RotateAroundAxis createShieldHammerRotateController(Transform rotateTrans)
		{
			return null;
		}

		private void createBullets()
		{
		}

		private void setUpSingleBullet(GameObject obj, Transform parent, float deltaDegree, float radius, int i)
		{
		}

		private void setUpSingleBulletInternal(GameObject obj, float deltaDegree, float radius, int i)
		{
		}

		private void moveBullets()
		{
		}

		private float getRotateSpeedPerSecond(float initialValue)
		{
			return 0f;
		}
	}

	public class ShieldHammerController
	{
		public string ExternalTag;

		public EntityBase m_Entity;

		public float initialShieldHammerAliveTime;

		private float curShieldHammerTime;

		public ShieldHammerCreator Creator;

		public ShieldHammerController(ShieldHammerCreator _creator)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void onUpdate(float deltaTime)
		{
		}

		private void updateShieldHammerAliveTime()
		{
		}

		private float getShieldHammerAliveTime()
		{
			return 0f;
		}

		public void resetShieldHammerTime()
		{
		}
	}

	private const string CREATOR_UPDATE_NAME = "SkillAlone1953-Update";

	private float releaseShieldHammerRate;

	private int shieldHammerCount;

	private float shieldHammerAliveTime;

	private float recoverHPPercent;

	private int shieldHammerDebuff;

	private float shieldHammerCDTime;

	private float shieldHammerRadius;

	private float ShieldHammerRotateSpeedPerFrame;

	private float shieldHammerAtkPercent;

	private ConditionTime shieldHammerCD;

	public ShieldHammerController shieldHammerController;

	private ShieldHammerCreator shieldHammerCreator;

	public ShieldHammerController cloneShieldHammerController;

	private ShieldHammerCreator cloneShieldHammerCreator;

	protected override void OnInstall()
	{
	}

	private ShieldHammerCreator createShieldHammerCreator()
	{
		return null;
	}

	private ShieldHammerController createShieldHammerController(ShieldHammerCreator creator)
	{
		return null;
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onKill(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	protected override void parseArgs()
	{
	}

	private void onHitAction(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void syncShieldHammer()
	{
	}

	private void syncShieldHammerResetTime()
	{
	}
}

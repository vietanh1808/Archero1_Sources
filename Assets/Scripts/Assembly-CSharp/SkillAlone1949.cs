using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1949 : SkillAloneBase
{
	public class AllThunderBeamController
	{
		public List<ThunderBeamController> thunderBeamControllers;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public void OnGotoNextRoom()
		{
		}

		public void AddController(ThunderBeamController controller)
		{
		}

		public void RemoveController(ThunderBeamController controller)
		{
		}

		public bool IsAroundRevengeThunder(Vector3 pos, float radius)
		{
			return false;
		}
	}

	public class ThunderBeamController
	{
		public int guid;

		private const string UPDATE_NAME = "ThunderBeamController-UPDATE";

		public string ExternalTag;

		public EntityBase m_Entity;

		public Vector3 RevengeThunderPos;

		public float ThunderBeamCDTime;

		public float TotalTime;

		public float ThunderBeamAtkPercent;

		public float RevengeThunderAtkPercent;

		private ConditionTime thunderBeamCD;

		private float currentTime;

		private AllThunderBeamController parentController;

		private BulletBase revengeBullet;

		public ThunderBeamController(AllThunderBeamController _parentController)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		protected void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
		{
		}

		private void onUpdate(float obj)
		{
		}

		private void updateThunderBeamPerCD()
		{
		}

		private void createThunderBeam()
		{
		}

		private void createThunderBeamInternal(Vector3 bulletPos, float eulerAngleY)
		{
		}

		private void syncThunderBeam(Vector3 bulletPos, float eulerAngleY)
		{
		}

		private EntityBase getAvailableEnemy()
		{
			return null;
		}

		private void createRevengeThunderWrapper()
		{
		}

		private void createRevengeThunder(Vector3 pos)
		{
		}

		private void clearRevengeThunder()
		{
		}
	}

	public class FallThunderController
	{
		public string ExternalTag;

		public float FallThunderCDTime;

		private Dictionary<EntityBase, ConditionTime> fallThunderCDDict;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public void OnGotoNextRoom()
		{
		}

		public void OnRemoveEnemy(EntityBase entity)
		{
		}

		public void RefreshFallThunderCD(EntityBase entity)
		{
		}

		public bool CanCreateFallThunder(EntityBase entity)
		{
			return false;
		}

		private ConditionTime getFallThunderCD(EntityBase entity)
		{
			return null;
		}
	}

	private int hammerBuff;

	private int thunderDebuff;

	private float fallThunderRate;

	private float fallThunderCDTime;

	private float fallThunderAtkPercent;

	private float revengeThunderRate;

	private float revengeThunderCDTime;

	private float revengeThunderAtkPercent;

	private float totalRevengeThunderTime;

	private float thunderBeamAtkPercent;

	private float thunderBeamCDTime;

	private bool addHammerBuff;

	private FallThunderController fallThunderController;

	protected AllThunderBeamController allThunderBeamController;

	private ConditionTime revengeThunderCD;

	private int thunderBeamGUID;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	public int GetThunderBeamGUID()
	{
		return 0;
	}

	protected virtual void parseArgs()
	{
	}

	private void syncZeusShieldHammerModelStr()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onHitted(EntityBase enemy, long realhit, HitStruct hs)
	{
	}

	private void syncThunderBeamController(Vector3 _pos, int guid)
	{
	}

	private void onHit(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	protected virtual void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onRemoveEnemy(EntityBase enemy)
	{
	}

	private ThunderBeamController createThunderBeamController(Vector3 revengeThunderPos, int _guid)
	{
		return null;
	}

	private void initHammerBuff()
	{
	}

	private void removeHammerBuff()
	{
	}

	private void initThunderDebuff()
	{
	}

	private void initEvents()
	{
	}

	private void removeEvents()
	{
	}

	private void initFallThunderController()
	{
	}

	private void removeFallThunderController()
	{
	}

	private void initThunderBeamController()
	{
	}

	private void removeThunderBeamController()
	{
	}
}

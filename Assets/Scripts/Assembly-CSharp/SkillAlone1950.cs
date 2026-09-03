using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1950 : SkillAloneBase
{
	public class FallThunderAction
	{
		public string ExternalTag;

		public EntityBase m_Entity;

		public Vector3 BulletPos;

		public float fallThunderAtkPercent;

		public float delayTime;

		public bool IsEnd;

		private ActionBasic mAction;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public void Execute()
		{
		}

		private void createFallThunder(Vector3 bulletPos)
		{
		}
	}

	private float delayTime;

	private float callFallThunderRate;

	private float fallThunderAtkPercent;

	private List<FallThunderAction> fallThunderActions;

	private Vector3 bulletPos;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onHit(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	public FallThunderAction getReadyFallThunderAction(Vector3 bulletPos)
	{
		return null;
	}
}

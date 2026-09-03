using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAloneAttrGoodBase : MonoBehaviour
{
	public class EffectClass
	{
		public GameObject o;

		public SkillAloneAttrGoodBase[] list;

		public bool bGotoRoomDeInit;

		public void OnGotoNextRoom(RoomGenerateBase.Room room)
		{
		}

		public void Init(EntityBase entity, params float[] args)
		{
		}

		public void DeInit()
		{
		}
	}

	private static Dictionary<GameObject, EffectClass> mList;

	private static List<GameObject> mRemoveList;

	protected EntityBase m_Entity;

	protected float[] args;

	public bool bGotoRoomDeInit;

	private ParticleSystem[] particles;

	private MeshRenderer[] meshes;

	private Sequence seq;

	public static SkillAloneAttrGoodBase[] Add(EntityBase entity, GameObject o, bool bGotoRoomDeInit, params float[] args)
	{
		return null;
	}

	public static bool Remove(GameObject o)
	{
		return false;
	}

	public static void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private static bool canAdd2RemoveList(GameObject go)
	{
		return false;
	}

	public static void InitData()
	{
	}

	public static void DeInitData()
	{
	}

	public void Init(EntityBase entity, params float[] args)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	private void KillSequence()
	{
	}

	public void OntoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	private void OnTriggerStay(Collider o)
	{
	}

	private void OnTriggerExit(Collider o)
	{
	}

	protected virtual void TriggerEnter(EntityBase entity)
	{
	}

	protected virtual void TriggerStay(EntityBase entity)
	{
	}

	protected virtual void TriggerAllEntityEnter(EntityBase entity)
	{
	}

	protected virtual void TriggerAllEntityStay(EntityBase entity)
	{
	}

	protected virtual void TriggerAllEntityExit(EntityBase entity)
	{
	}

	protected void Attack(EntityBase entity, float hitratio)
	{
	}
}

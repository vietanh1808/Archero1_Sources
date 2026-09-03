using System;
using UnityEngine;

public class RoomControlBase : MonoBehaviour
{
	public class Mode_LevelData
	{
		public RoomGenerateBase.Room room;

		public RoomGenerateBase.Room nextroom;
	}

	public Action<RoomControlBase, bool> OpenDoorDelgate;

	protected bool m_bOpenDoor;

	protected object mInitData;

	private Transform cloudparent;

	private Transform cloud01;

	private Transform cloud02;

	private const float CloudMinDistance = 4f;

	private bool bCloudInit;

	private float mCloud01MoveTime;

	private float mCloud02MoveTime;

	private float cloud01y;

	private float cloud02y;

	private float randomheight;

	private Transform Collider_Parent;

	private Transform Collider_Door;

	private Transform Collider_Up;

	private Transform Collider_UpSide;

	private Transform Collider_Left;

	private Transform Collider_Right;

	private Transform Collider_Down;

	private Transform _GoodsDropParent;

	private Transform _GoodsParent;

	private TextMesh[] texts_layer;

	private MeshRenderer textMeshrenderer;

	public Mode_LevelData RoomData => null;

	protected Transform GoodsDropParent => null;

	public Transform GoodsParent => null;

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public void Init(object data = null)
	{
	}

	protected virtual void OnInit(object data = null)
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void OnEnabled()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void OnDisabled()
	{
	}

	public void OpenDoor(bool value)
	{
	}

	public void OpenDefaultDoor(bool value)
	{
	}

	private void CreatePortals()
	{
	}

	protected virtual void OnOpenDoor(bool value)
	{
	}

	public bool IsDoorOpen()
	{
		return false;
	}

	public void LayerShow(bool value)
	{
	}

	protected virtual void OnLayerShow(bool value)
	{
	}

	public void SetText(string value)
	{
	}

	protected virtual void OnSetText(string value)
	{
	}

	public void Clear()
	{
	}

	public void ClearGoods()
	{
	}

	protected virtual void OnClearGoods()
	{
	}

	public void ClearGoodsDrop()
	{
	}

	protected virtual void OnClearGoodsDrop()
	{
	}

	public Transform GetGoodsDropParent()
	{
		return null;
	}

	protected virtual Transform OnGetGoodsDropParent()
	{
		return null;
	}

	protected virtual void OnReceiveEvent(string eventName, object data)
	{
	}

	public void SendEvent(string eventName, object data = null)
	{
	}

	protected void TryInvokeDoorChangeEvent(bool isDoorOpen)
	{
	}

	private void CloudAwake()
	{
	}

	private void InitCloud()
	{
	}

	private void RandomCloudY(ref float clouda, float cloudb)
	{
	}

	private void CloudUpdate()
	{
	}

	private void ColliderAwake()
	{
	}

	private void Collider_OpenDoor(bool open)
	{
	}

	private void LayerAwake()
	{
	}

	protected void SetLayer(int layer)
	{
	}

	protected void SetLayer(string value)
	{
	}

	public void SetTextLayerVisible(bool active)
	{
	}
}

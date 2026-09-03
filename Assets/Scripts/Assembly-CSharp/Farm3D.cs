using System.Collections.Generic;
using UnityEngine;

public class Farm3D : MonoBehaviour
{
	public Camera Camera_Farm;

	public Camera Camera_MapOutWall;

	private Vector3 cameraBasicPos;

	public GameObject mapRoot;

	public GameObject eventRoot;

	public GameObject monsterRoot;

	public GameObject cpMonster;

	private int map;

	private int type;

	private List<Vector3> farmPointList;

	[HideInInspector]
	private Dictionary<int, FarmItem> farmItemDict;

	public static float SCALE_X;

	private Dictionary<int, Farm3DSet> farm3DSet;

	public GameObject CampObj;

	private float scale;

	private float scalex;

	private float scaley;

	private float design;

	private float real;

	public void init(RenderTexture tex)
	{
	}

	public void addMonster(int type)
	{
	}

	private int getMap(int count)
	{
		return 0;
	}

	public MonsterOne getMonsterOne(int mid)
	{
		return null;
	}

	public void createFarmPoint()
	{
	}

	public Vector3 getFarmRandomPoint()
	{
		return default;
	}

	public void addFarmItems()
	{
	}

	public int checkClickItem(Vector2 position)
	{
		return 0;
	}

	public void handleCleanAllEvent()
	{
	}

	public void handlePooAndStone(FarmOneData data)
	{
	}

	public void handleHole(FarmOneData data)
	{
	}

	public void RemoveEvent(int type, int eventId)
	{
	}

	public void setFarmCarmera(float offsetx)
	{
	}

	public Vector3 World2Screen(Vector3 worldpos)
	{
		return default;
	}
}

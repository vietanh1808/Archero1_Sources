using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class MapCreatorObjectData
{
	public class ObjectData
	{
		public int posx;

		public int posy;

		public GameObject gameObject;

		public Vector3 startPostion;

		public string name;

		public EntityBase entity;

		public ObjectData(int x, int y, GameObject obj)
		{
		}

		public void SetActive(bool pActive)
		{
		}

		public void ActiveLife()
		{
		}

		public void MoveTo(Vector3 tarPos)
		{
		}

		public void MoveToStartPosition()
		{
		}
	}

	public int index;

	public int width { get; private set; }

	public int height { get; private set; }

	public int[,] tiledata { get; private set; }

	public List<ObjectData> objects { get; private set; }

	public bool Created { get; set; }

	public XmlNode node { get; private set; }

	public Dictionary<Vector2Int, MapCreator.HeroModeData> elitelist { get; private set; }

	public List<MapCreator.HeroModeData> bosslist { get; private set; }

	public List<MapCreator.HeroModeData> monsterlist { get; private set; }

	public MapCreatorObjectData(int w, int h)
	{
	}

	public void InitByNode(XmlNode pNode)
	{
	}

	public void CreatTileData()
	{
	}

	public ObjectData AddObject(int x, int y, GameObject obj)
	{
		return null;
	}

	public void SetActive(bool pActive)
	{
	}

	public void ActiveLife()
	{
	}

	public void MoveTo(Vector3 tarPos)
	{
	}

	public void MoveToStartPosition()
	{
	}
}

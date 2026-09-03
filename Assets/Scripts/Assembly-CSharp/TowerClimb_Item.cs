using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TowerClimb_Item : UILoopScrollList_Item
{
	public class TowerClimb_HeroModel_Data
	{
		public HeroShow heroShow;

		public BodyMask model;

		public GameObject weaponModel;

		public GameObject dualWeaponModel;

		public int clothId;

		public int weaponId;

		public bool isLoadingModel;
	}

	private const int HeroDataIndex = 1;

	private const int MonsterDataIndex = 2;

	public RawImage img_heroShow;

	public Transform heroParent;

	public Transform monsterParent;

	public Image image_Back;

	public Image image_TitleFloor;

	public Image image_Boss;

	public Image image_OpenDoor;

	public DxxText Text_Floor;

	public DxxText Text_Finish;

	public GameObject cloud;

	public ParticleSystem cloudParticle;

	public GameObject heroCloud;

	public ParticleSystem heroCloudParticle;

	private TowerClimb_HeroModel_Data mHeroData;

	private Tower_TowerConfig tableData;

	private Dictionary<int, Queue<BodyMask>> monsterDic;

	private Renderer cloudRender;

	private Color cloudStartColor;

	private const float MONSTER_SPACE = 2.5f;

	private bool isPlayingAnim;

	private int index;

	private int _curWeaponColorID;

	public override void OnListEnable()
	{
	}

	public override void OnCreate()
	{
	}

	public override void OnRecycle()
	{
	}

	private void RecycleHero()
	{
	}

	private void RecycleMonster()
	{
	}

	private void Update()
	{
	}

	public override void Refresh(object data, int index)
	{
	}

	private void SetBossImage(int index)
	{
	}

	private void SetLayerTitleImage(int index)
	{
	}

	private void SetImageOpenDoor(int index)
	{
	}

	private void LoadHeroModel()
	{
	}

	private int GetWeaponIdById(int weaponId)
	{
		return 0;
	}

	private void OnHeroLoadComplete(TowerClimb_HeroModel_Data heroData)
	{
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	private void LoadMonster()
	{
	}

	public override void OnScrollEnd()
	{
	}
}

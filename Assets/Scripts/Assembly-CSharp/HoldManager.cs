using UnityEngine;

public class HoldManager : MonoBehaviour
{
	private SoundManager _Sound;

	private LanguageManager _Language;

	private DropManager _Drop;

	private HoldPoolManager _Pool;

	private GuideManager _Guide;

	private int mPreLoadCount;

	private BattleModuleData _BattleData;

	public SoundManager Sound => null;

	public LanguageManager Language => null;

	public DropManager Drop => null;

	public HoldPoolManager Pool => null;

	public GuideManager Guide => null;

	public BattleModuleData BattleData => null;

	private void Awake()
	{
	}

	public void SetSound(SoundManager sound)
	{
	}

	public void BattleDataReset()
	{
	}

	public void GotoBattle()
	{
	}

	public void PreLoad(int id)
	{
	}

	public void PreLoadPlayerBullets(string[] s)
	{
	}

	private void PreLoadBullets(string[] s)
	{
	}

	private void PreLoadEffects(int[] s)
	{
	}

	private void PreLoadGoods(string[] s)
	{
	}

	public void PreLoadPlayerBullet(int BulletID, int count)
	{
	}

	private void PreLoadBullet(int BulletID, int count)
	{
	}

	private void PreLoadGoods(int goodid, int count)
	{
	}

	private void PreLoadEffect(int id, int count)
	{
	}

	private void PreLoadMapEffects(string[] s)
	{
	}

	private void PreLoadMapEffect(string path, int count)
	{
	}
}

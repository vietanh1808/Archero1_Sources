using DG.Tweening;
using UnityEngine;

public class SkillAlone2230 : SkillAloneArtifactBase
{
	private float skillLastTime;

	private int originOilLampCount;

	private int maxOilLampCount;

	private string skillStatusAddSelfBuffID1;

	private string skillStatusAddSelfBuffID2;

	public const int SkillEffectBaseID = 2230;

	private int[] skillStatusAddSelfBuffID1Array;

	private int[] skillStatusAddSelfBuffID2Array;

	protected int curOilLampCount;

	protected bool needClearSkillStart;

	private Tween delayCall;

	private Material environmentEffect;

	private GameObject skillBaseEffect;

	private long storeTargetHP;

	private bool startChange;

	private float startLastTime;

	private float curValue;

	private CameraHellInvironmentCtrl effectCtrl;

	protected virtual float RealSkillLastTime => 0f;

	private RoomGenerateBase RoomGenerate => null;

	protected virtual int CastSkillAddOilLampCount => 0;

	private LocalSave.Skill2230VO Skill2230VO => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void CastSkill()
	{
	}

	protected override void SkillStart()
	{
	}

	protected override void SkillEnd()
	{
	}

	protected override void SkillClear()
	{
	}

	protected virtual void OnArtifact302ShieldCountChange(int curCount, bool isFromClear)
	{
	}

	private void LoadEnvironmentEffect()
	{
	}

	private void UnLoadEnvironmentEffect()
	{
	}

	private ArtifactType OnArtifactSkill2230Type()
	{
		return ArtifactType.None;
	}

	private bool OnArtifact302SkillStatus()
	{
		return false;
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private new void OnUpdate(float delta)
	{
	}

	private void ChangeEntityHP(long delta)
	{
	}

	private int[] ParseBuffID(string buffArrays)
	{
		return null;
	}
}

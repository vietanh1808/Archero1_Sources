using DG.Tweening;
using UnityEngine;

public class PetBirthVO : PetVOBase
{
	public enum PetCreateType
	{
		None = 0,
		PlayerRadiusRandom = 1,
		EnemyBossRadiusRandom = 2,
		PlayerAndEnemyRadiusRandom = 3
	}

	public const float shortMaxPercent = 0.5f;

	public const float longMaxPercent = 0.5f;

	public const float shortDis = 2f;

	public const float longDis = 5f;

	public const float bezierSpeed = 0.02f;

	public const float testDis = 5f;

	private const string LOG_TAG = "[PetBirthVO]";

	private float SHORT_DIS;

	private float LONG_DIS;

	private float BEZIER_SPEED;

	private float SHORT_MAX_PERCENT;

	private float LONG_MIN_PERCENT;

	private GameObject goBall;

	private GameObject goAppear;

	private GameObject goDisappear;

	private EntityPetBase pet;

	private ActionBezierCurveForObj bezier;

	private Vector3? endCenterPos;

	private Tween ballTween;

	private Tween appearTween;

	private Tween disappearTween;

	private Tween disappearEffectDone;

	private Vector3 endPos;

	private string folderPath;

	private const string DEFAULT_COLOR = "green";

	private Coroutine appearCoroutine;

	private Coroutine disappearCoroutine;

	public EntityPetBase Pet => null;

	public PetArtificialLeaveType ArtificialLeaveType(BattlePetVO battlePetVo)
	{
		return PetArtificialLeaveType.None;
	}

	public PetMoveType MoveType(BattlePetVO battlePetVo)
	{
		return PetMoveType.None;
	}

	public PetBirthVO(BattlePetVO battlePetVO)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnThroughDoor()
	{
	}

	public void CreatePetBall()
	{
	}

	private void clearTweens()
	{
	}

	private void clearEffects()
	{
	}

	public void SetEndCenterPos(Vector3? endCenterPos)
	{
	}

	private string getPetColor()
	{
		return null;
	}

	private void onArrivedCallback()
	{
	}

	private void createPet(Vector3 petPos)
	{
	}

	private void inheritAttrs()
	{
	}

	private long getAttrValueLong(float percentage)
	{
		return 0L;
	}

	private void createFootCircle(Transform parent)
	{
	}

	public void CheckSetPetPos(CheckPetTime checkPetTime, BattlePetVO battlePetVo)
	{
	}

	public void CheckClearPet(CheckPetTime checkPetTime, BattlePetVO battlePetVo)
	{
	}

	private void ClearPetImmediately(BattlePetVO battlePetVo)
	{
	}

	private void ClearAllPetImmediately(BattlePetVO battlePetVo)
	{
	}

	private void ClearPetWithAni(BattlePetVO battlePetVo)
	{
	}

	private float getBezierSpeed(float dis)
	{
		return 0f;
	}

	private Vector3 getCreatePetEndPos(BattlePetVO battlePetData)
	{
		return default;
	}

	private Vector3 GetPlayerRadiusRandomPos(int positionRange)
	{
		return default;
	}

	private Vector3 GetEnemyBossRadiusRandomPos(int positionRange)
	{
		return default;
	}

	private Vector3 GetPlayerAndEnemyRadiusRandom(float playerHpPercent, float triggerHpPercent, int positionRange)
	{
		return default;
	}

	public void Dead(TweenCallback effectDone)
	{
	}
}

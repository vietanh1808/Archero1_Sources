using UnityEngine;

public class ToxicfogManager : Singleton<ToxicfogManager>
{
	private const string TAG = "ToxicfogManager";

	public const int GOOD_ID = 3001;

	public const float RADIUS = 29.2f;

	private LocalUnityObjctPool _pool;

	private int[] _vecAngles;

	private Vector3[] _vecDirs;

	private Vector3[] _vecVerticalDirs;

	private Vector3[] _vecDrawLineStartPos;

	private Vector3[] _vecDrawLineEndPos;

	private float[] _vecSpeeds;

	private float[] _vecTimes;

	private float[] _vecDistances;

	private int[][] _vecGrids;

	private Vector3[][] _vecGridCorners;

	private Vector3[] _vecCenters;

	private float _fRoomStartTime;

	private int _nWidth;

	private int _nCnt;

	private int _nBuffId;

	private const float INTERVAL = 0.1f;

	private float _fTime;

	private bool _bBuffAddedFlag;

	public int[] VecAngles => null;

	public Vector3[] VecDirs => null;

	public Vector3[] VecVerticalDirs => null;

	public Vector3[] VecDrawLineStartPos => null;

	public Vector3[] VecDrawLineEndPos => null;

	public float[] VecSpeeds => null;

	public float[] VecTimes => null;

	public float[] VecDistances => null;

	public int[][] VecGrids => null;

	public Vector3[][] VecGridCorners => null;

	public Vector3[] VecCenters => null;

	public float RoomStartTime => 0f;

	public int Width => 0;

	public int Cnt => 0;

	public bool ShowToxicFog => false;

	public float Time(int i)
	{
		return 0f;
	}

	public float CD(int i)
	{
		return 0f;
	}

	public float Progress(int i)
	{
		return 0f;
	}

	public float MaxTime(int i)
	{
		return 0f;
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void OnOpenDoor()
	{
	}

	public bool OnGotoNextDoorAfter()
	{
		return false;
	}

	private bool InitToxicfogById(int id)
	{
		return false;
	}

	private bool IsDaily130()
	{
		return false;
	}

	private int GetDaily130BossToxicfogId()
	{
		return 0;
	}

	private int RandomToxicfog()
	{
		return 0;
	}

	private Vector3 CalStartPos(int width, int height, float zScale, float angle)
	{
		return default;
	}

	private Vector3 CalEndPos(int width, int height, float zScale, int angle, float min, float max, int nGridCnt)
	{
		return default;
	}

	private void InitGrids(int width, int height, int angle, int i, int nGridCnt, Vector3 endPos, Vector3 verticalDir, float zScale)
	{
	}

	private float DistanceAlongDirection(Vector3 p1, Vector3 p2, Vector3 direction)
	{
		return 0f;
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void OnWillDead()
	{
	}

	private bool RandomFogRoom(int nCurRoomId, out int id)
	{
		id = default;
		return false;
	}
}

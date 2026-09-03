using UnityEngine;

public class MeadowBattleConfig
{
	public const string LOG_TAG = "[牧场对战]";

	public const string LOG_ATTRITBUE_TAG = "[牧场对战-属性]";

	public const string open_arena = "open_arena";

	public const string battle_start = "battle_start";

	public const string open_ranking = "open_ranking";

	public const string defensive_settings = "defensive_settings";

	public const string battle_reward = "battle_reward";

	public const string egg_reward = "egg_reward";

	public const string battle_begin = "battle_begin";

	public const string battle_end = "battle_end";

	public const string battle_surrender = "battle_surrender";

	public const int Unlock_Chapter = 6;

	public const int Min_Battle_Monster_Count = 3;

	public const float duration = 0.5f;

	public const int Evolution_Attack_Rate_ID = 1;

	public const int Evolution_Life_Rate_ID = 2;

	public const int Evolution_MoveSpeed_Rate_ID = 3;

	public const int Pay_Match_Diamond_Cost_ID = 4;

	public const int Total_Points_ID = 5;

	public const int Rank_Weight_ID = 6;

	public const int Free_Match_ID = 7;

	public const int Win_Delta_Score_ID = 8;

	public const int Lose_Delta_Score_ID = 9;

	public const int Red_Circle_ID = 3100078;

	public const int Green_Circle_ID = 3100077;

	public const int WIDTH = 11;

	public const int HEIGHT = 21;

	public const int MIN_ROW = 0;

	public const int MIN_COL = 0;

	public const int MAX_ROW = 20;

	public const int MAX_COL = 10;

	public static int STAGE_HEIGHT;

	public static int STAGE_WIDTH;

	public static float CameraSizeFactor;

	public const float DesignFormationCameraSize = 13.95f;

	public const float BattleCameraSize = 12.9f;

	public const float DefaultCameraSize = 10.5f;

	public static Vector3 DefaultCameraPos;

	public static Vector3 CameraPos;

	public static Quaternion CameraRotation;

	public const int WanderWeight = 20;

	public static Vector3 TileScale => default;
}

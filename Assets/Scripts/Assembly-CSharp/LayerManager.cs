public class LayerManager
{
	public enum BulletLayer
	{
		eAll = 0,
		eOnlyOut = 1,
		eNone = 2,
		eAllWithWater = 3
	}

	public static int UI;

	public static int BackGround;

	public static int Player;

	public static int NetPlayer;

	public static int NetMonster;

	public static int Map;

	public static int Goods;

	public static int Fly;

	public static int MapOutWall;

	public static int Bullet;

	public static int Bullet2Map;

	public static int PlayerAbsorb;

	public static int PlayerAbsorbImme;

	public static int Entity2MapOutWall;

	public static int Entity2Stone;

	public static int Entity2Water;

	public static int Stone;

	public static int Waters;

	public static int BattleHits;

	public static int BulletResist;

	public static int Hide;

	public static int Farm3D;

	public static int[] BulletTriggers;

	public static int HitEntity;

	public static int MapAllInt;

	public static int Move_Fly;

	public static int Move_Ground;

	public static int MeadowBattleMonster;

	public const int RenderQueue_Fly = 3000;

	public const int RenderQueue_Default = 2000;

	static LayerManager()
	{
	}

	public static bool IsCollisionMap(int layer)
	{
		return false;
	}

	public static int GetBullet(BulletLayer type)
	{
		return 0;
	}
}

using UnityEngine;

public class GameNode
{
	private static GameObject m_NetP;

	private static Transform m_HPP;

	private static Transform m_RootP;

	private static Transform m_JoyP;

	private static Transform m_UIMainP;

	private static Transform m_InGameP;

	private static Transform m_InGame2P;

	private static Transform m_FrontP;

	private static Transform m_FrontEventP;

	private static Transform m_Front2P;

	private static Transform m_Front3P;

	private static Transform m_FrontMaskP;

	private static Transform m_FrontNetP;

	private static Transform m_TipsUIP;

	private static Transform m_FrontForceP;

	private static GameObject m_LightP;

	private static GameObject m_CameraParentP;

	private static Camera m_CameraP;

	private static Animation m_CameraAniP;

	private static Camera m_UICameraP;

	private static Transform m_TipsP;

	private static GameObject m_BattleP;

	private static GameObject m_RoomP;

	private static GameObject m_MonsterP;

	private static GameObject m_SurviveResP;

	private static GameObject m_MainP;

	private static Transform m_PoolParentP;

	private static Transform m_PoolMapParentP;

	private static Transform m_PoolMapParentShowP;

	private static Transform m_PlayerBulletP;

	private static Transform m_BulletParentP;

	private static AudioSource mBackgroundMusic;

	private static Transform mSoundNode;

	private static Transform mMapCacheNode;

	public static GameObject m_Net => null;

	public static Transform m_HP => null;

	public static Transform m_Root => null;

	public static Transform m_Joy => null;

	public static Transform m_UIMain => null;

	public static Transform m_InGame => null;

	public static Transform m_InGame2 => null;

	public static Transform m_Front => null;

	public static Transform m_FrontEvent => null;

	public static Transform m_Front2 => null;

	public static Transform m_Front3 => null;

	public static Transform m_FrontMask => null;

	public static Transform m_FrontNet => null;

	public static Transform m_TipsUI => null;

	public static Transform m_FrontForce => null;

	public static GameObject m_Light => null;

	public static GameObject m_CameraParent => null;

	public static Camera m_Camera => null;

	private static Animation m_CameraAni => null;

	public static Camera m_UICamera => null;

	public static Transform m_Tips => null;

	public static GameObject m_Battle => null;

	public static GameObject m_Room => null;

	public static GameObject m_Monster => null;

	public static GameObject m_SurviveResRoot => null;

	public static GameObject m_MainMapRoot => null;

	public static Transform m_PoolParent => null;

	public static Transform m_PoolMapParent => null;

	public static Transform m_PoolMapParentShow => null;

	public static Transform m_PlayerBullet => null;

	public static Transform m_BulletParent => null;

	public static AudioSource BackgroundMusic => null;

	public static Transform SoundNode => null;

	public static Transform MapCacheNode => null;

	public static void CameraShake(CameraShakeType type)
	{
	}

	public static void ClearRoom()
	{
	}

	public static void ClearBattleRoot()
	{
	}

	public static void DestroyMonsterNode()
	{
	}
}

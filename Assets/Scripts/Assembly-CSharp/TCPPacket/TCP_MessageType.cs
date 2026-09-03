namespace TCPPacket
{
	public class TCP_MessageType
	{
		public const ushort PlayerData = 1;

		public const ushort EquipData = 2;

		public const ushort CardData = 3;

		public const ushort RoomReady = 4;

		public const ushort EnterGame = 5;

		public const ushort RoomData = 6;

		public const ushort RoomLoadComplete = 7;

		public const ushort BeginBattle = 8;

		public const ushort GotoNextRoom = 9;

		public const ushort Vector3 = 10;

		public const ushort BeginLoadMap = 11;

		public const ushort OtherPlayerDisconnect = 12;

		public const ushort ApplicationPause = 13;

		public const ushort GoodData = 14;

		public const ushort PlayerDataPVP = 15;

		public const ushort PlayerProofreadingAtt = 16;

		public const ushort EnterDoor = 17;

		public const ushort Vector4 = 20;

		public const ushort CSEnterRoom = 101;

		public const ushort SCEnterRoom = 102;

		public const ushort CSHeartBeat = 103;

		public const ushort SCHeartBeat = 104;

		public const ushort SCAllPlayerInRoom = 105;

		public const ushort UpdateScore = 106;

		public const ushort PvPEnterRoomRequest = 201;

		public const ushort PvPEnterRoomResponse = 202;

		public const ushort PvPBattleReadyRequest = 203;

		public const ushort PvPBattelStartResponse = 204;

		public const ushort PvPUserHeartbeatRequest = 205;

		public const ushort PvPUserHeartbeatResponse = 206;

		public const ushort PvPUserUpdateHpRequest = 207;

		public const ushort PvPUserDisconnResponse = 208;

		public const ushort PvPUserDieRequest = 209;

		public const ushort PvPBattleOverResponse = 210;

		public const ushort PvPEnterDoorRequest = 211;

		public const ushort PvPEnterDoorResponse = 212;

		public const ushort PvPEnterMapRequest = 213;

		public const ushort PvPBattleTransfer = 221;

		public const ushort PvPMatchSrvHeartBeat = 301;

		public const ushort PvPMatchSrvHeartBeatResponse = 302;

		public const ushort MoveCommand = 1001;

		public const ushort StopMoveCommand = 1002;

		public const ushort RoteCommand = 1003;

		public const ushort ActionCommand = 1004;

		public const ushort SetTargetCommand = 1005;

		public const ushort ChangeHpCommand = 1006;

		public const ushort BuffCommand = 1007;

		public const ushort RoteTargetCommand = 1008;

		public const ushort AttackCommand = 1009;

		public const ushort LearnSkillCommand = 1010;

		public const ushort ExcuteAttrCommand = 1011;

		public const ushort RebornCommand = 1012;

		public const ushort HeroDeadCommand = 1013;

		public const ushort PlaySoundMessage = 1014;

		public const ushort CreateBulletMessage = 1015;

		public const ushort BehaviorCommand = 1016;

		public const ushort CreatePartBodyMessage = 1017;

		public const ushort DeleteEntity = 1018;

		public const ushort Teleport = 1019;

		public const ushort ChangeAttackState = 1020;

		public const ushort OnHitOnce = 1021;

		public const ushort ExpressionMsg = 1022;

		public const ushort CustomJsonMsg = 1100;
	}
}

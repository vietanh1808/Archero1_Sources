using System.Collections.Generic;
using System.Xml;

namespace NewPlay125
{
	public class XmlParser
	{
		private const string LOG_TAG = "[XmlParser]";

		private XmlDocument xmlDoc;

		private XmlNodeList xmlNodes;

		public XmlParser(string path)
		{
		}

		public void DeInit()
		{
		}

		public List<SingleWavePosVO> GetSingleWaveBirthPosVOs(string ID)
		{
			return null;
		}

		public int[,] GetTileDataById(string id)
		{
			return null;
		}

		private XmlNode getMapNodeById(string id)
		{
			return null;
		}

		private bool isMonsterPos(int id)
		{
			return false;
		}

		private bool isBossPos(int id)
		{
			return false;
		}

		private bool isEventPos(int id)
		{
			return false;
		}
	}
}

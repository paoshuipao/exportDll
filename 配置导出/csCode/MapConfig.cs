
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class MapConfigData : IConfig 
	{
		
		public int mapId;

		public string name;

		public int enterX;

		public int enterY;

		public int enterZ;

		public int lowerLimit;

		public int upperLimit;

		public int level;

		public bool fight;

		public bool calculatePK;

		public int screenType;

		public bool singleGame;

		public bool teamLimit;

		public bool guildLimit;

		public bool vipLimit;

		public bool propsLimit;

		public string skillLimit;

		public bool propsRevive;

		public int goodsLifeTime;

		public string mapBgMusic;

		public string limitTip;

		public string description;

		public MapConfigData(int mapId1, string name1, int enterX1, int enterY1, int enterZ1, int lowerLimit1, int upperLimit1, int level1, bool fight1, bool calculatePK1, int screenType1, bool singleGame1, bool teamLimit1, bool guildLimit1, bool vipLimit1, bool propsLimit1, string skillLimit1, bool propsRevive1, int goodsLifeTime1, string mapBgMusic1, string limitTip1, string description1) 
		{
			
			mapId=mapId1;

			name=name1;

			enterX=enterX1;

			enterY=enterY1;

			enterZ=enterZ1;

			lowerLimit=lowerLimit1;

			upperLimit=upperLimit1;

			level=level1;

			fight=fight1;

			calculatePK=calculatePK1;

			screenType=screenType1;

			singleGame=singleGame1;

			teamLimit=teamLimit1;

			guildLimit=guildLimit1;

			vipLimit=vipLimit1;

			propsLimit=propsLimit1;

			skillLimit=skillLimit1;

			propsRevive=propsRevive1;

			goodsLifeTime=goodsLifeTime1;

			mapBgMusic=mapBgMusic1;

			limitTip=limitTip1;

			description=description1;

		}
	}

	public partial class GameData 
	{
		
		public static List<MapConfigData> MapConfig = new List<MapConfigData>() 
		{
			
			new MapConfigData(1, "主城", 90, 1025927, 133, 1, 999, 1, false, true, 0, false, true, false, false, false, "", true, 60, "", "", "曾经辉煌一时的大城堡，而限制已经被大陆所遗忘。故事却要从这里开始"),

			new MapConfigData(2, "新手村", 19, 1000640, 17, 1, 999, 1, false, true, 0, false, true, false, false, false, "", true, 60, "", "", "曾经辉煌一时的大城堡，而限制已经被大陆所遗忘。故事却要从这里开始"),

		};

	}
}

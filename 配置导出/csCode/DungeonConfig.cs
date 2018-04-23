
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class DungeonConfigData : IConfig 
	{
		
		public string name;

		public string SceneName;

		public int Chapter;

		public string background;

		public bool isCity;

		public int condition;

		public DungeonConfigData(int id1, string name1, string SceneName1, int Chapter1, string background1, bool isCity1, int condition1) 
		{
			
			id=id1;

			name=name1;

			SceneName=SceneName1;

			Chapter=Chapter1;

			background=background1;

			isCity=isCity1;

			condition=condition1;

		}
	}

	public partial class GameData 
	{
		
		public static List<DungeonConfigData> DungeonConfig = new List<DungeonConfigData>() 
		{
			
			new DungeonConfigData(1, "主城", "mainCityScene", -1, "-1.0", false, 0),

			new DungeonConfigData(2, "新手村", "mainScene", -1, "TownBackground", true, 0),

			new DungeonConfigData(101, "试炼之境一层", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(102, "试炼之境二层", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(103, "试炼之境三层", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(104, "试炼之境四层", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(105, "魔神巢穴", "level_1-4", 1, "Mines", false, 102),

			new DungeonConfigData(106, "母巢", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(107, "瀛洲入侵", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(108, "幽冥鬼界", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(109, "苍狼穴", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(110, "试炼之境十层", "level_1-4", 1, "Mines", false, 0),

			new DungeonConfigData(201, "翠绿神庙一层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(202, "翠绿神庙二层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(203, "翠绿神庙三层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(204, "翠绿神庙四层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(205, "翠绿神庙五层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(206, "翠绿神庙六层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(207, "翠绿神庙七层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(208, "翠绿神庙八层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(209, "翠绿神庙九层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(210, "翠绿神庙十层", "level_1-4", 2, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(3, "远古战场", "level_1-4", -1, "Amb_SwampLoop", false, 0),

			new DungeonConfigData(4, "炸弹人战场", "level_1-4", -1, "Amb_SwampLoop", false, 0),

		};

	}
}

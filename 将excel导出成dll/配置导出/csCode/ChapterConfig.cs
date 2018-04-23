
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class ChapterConfigData : IConfig 
	{
		
		public string name;

		public string background;

		public ChapterConfigData(int id1, string name1, string background1) 
		{
			
			id=id1;

			name=name1;

			background=background1;

		}
		
		public override string ToString()
		{
			return "     章节ID- "+id+"     章节名称- "+name+"     章节背景图- "+background;
		}

	}

	public partial class GameData 
	{
		
		public static List<ChapterConfigData> ChapterConfig = new List<ChapterConfigData>() 
		{
			
			new ChapterConfigData(1, "第一章 粉碎的命运", "2.0"),

			new ChapterConfigData(2, "第二章 重生塔", ""),

			new ChapterConfigData(3, "斗魂塔1层", ""),

			new ChapterConfigData(4, "斗魂塔2层", ""),

			new ChapterConfigData(5, "斗魂塔3层", ""),

			new ChapterConfigData(6, "斗魂塔4层", ""),

			new ChapterConfigData(7, "斗魂塔5层", ""),

			new ChapterConfigData(8, "斗魂塔6层", ""),

			new ChapterConfigData(9, "斗魂塔7层", ""),

			new ChapterConfigData(10, "斗魂塔8层", ""),

			new ChapterConfigData(11, "斗魂塔9层", ""),

			new ChapterConfigData(12, "斗魂塔10层", ""),

			new ChapterConfigData(13, "斗魂塔11层", ""),

			new ChapterConfigData(14, "斗魂塔12层", ""),

			new ChapterConfigData(15, "斗魂塔13层", ""),

			new ChapterConfigData(16, "斗魂塔14层", ""),

			new ChapterConfigData(17, "斗魂塔15层", ""),

			new ChapterConfigData(18, "斗魂塔16层", ""),

			new ChapterConfigData(19, "斗魂塔17层", ""),

			new ChapterConfigData(20, "斗魂塔18层", ""),

			new ChapterConfigData(21, "斗魂塔19层", ""),

			new ChapterConfigData(22, "斗魂塔20层", ""),

			new ChapterConfigData(23, "斗魂塔21层", ""),

			new ChapterConfigData(24, "斗魂塔22层", ""),

			new ChapterConfigData(25, "斗魂塔23层", ""),

			new ChapterConfigData(26, "斗魂塔24层", ""),

			new ChapterConfigData(27, "斗魂塔25层", ""),

			new ChapterConfigData(28, "斗魂塔26层", ""),

			new ChapterConfigData(29, "斗魂塔27层", ""),

			new ChapterConfigData(30, "斗魂塔28层", ""),

			new ChapterConfigData(31, "斗魂塔29层", ""),

			new ChapterConfigData(32, "斗魂塔30层", ""),

			new ChapterConfigData(33, "斗魂塔31层", ""),

			new ChapterConfigData(34, "斗魂塔32层", ""),

			new ChapterConfigData(35, "斗魂塔33层", ""),

			new ChapterConfigData(36, "斗魂塔34层", ""),

		};

	}
}

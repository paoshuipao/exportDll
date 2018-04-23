
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class MonsterLevelExpData : IConfig 
	{
		
		public int exp;

		public MonsterLevelExpData(int id1, int exp1) 
		{
			
			id=id1;

			exp=exp1;

		}
	}

	public partial class GameData 
	{
		
		public static List<MonsterLevelExpData> MonsterLevelExp = new List<MonsterLevelExpData>() 
		{
			
			new MonsterLevelExpData(1, 100),

			new MonsterLevelExpData(2, 110),

			new MonsterLevelExpData(3, 120),

			new MonsterLevelExpData(4, 130),

			new MonsterLevelExpData(5, 140),

			new MonsterLevelExpData(6, 150),

			new MonsterLevelExpData(7, 160),

			new MonsterLevelExpData(8, 170),

			new MonsterLevelExpData(9, 180),

			new MonsterLevelExpData(10, 190),

			new MonsterLevelExpData(11, 200),

			new MonsterLevelExpData(12, 210),

			new MonsterLevelExpData(13, 220),

			new MonsterLevelExpData(14, 230),

			new MonsterLevelExpData(15, 240),

			new MonsterLevelExpData(16, 250),

			new MonsterLevelExpData(17, 260),

			new MonsterLevelExpData(18, 270),

			new MonsterLevelExpData(19, 280),

			new MonsterLevelExpData(20, 290),

			new MonsterLevelExpData(21, 300),

			new MonsterLevelExpData(22, 310),

			new MonsterLevelExpData(23, 320),

			new MonsterLevelExpData(24, 330),

			new MonsterLevelExpData(25, 340),

			new MonsterLevelExpData(26, 350),

			new MonsterLevelExpData(27, 360),

			new MonsterLevelExpData(28, 370),

			new MonsterLevelExpData(29, 380),

			new MonsterLevelExpData(30, 390),

			new MonsterLevelExpData(31, 400),

			new MonsterLevelExpData(32, 410),

			new MonsterLevelExpData(33, 420),

			new MonsterLevelExpData(34, 430),

			new MonsterLevelExpData(35, 440),

			new MonsterLevelExpData(36, 450),

			new MonsterLevelExpData(37, 460),

			new MonsterLevelExpData(38, 470),

			new MonsterLevelExpData(39, 480),

			new MonsterLevelExpData(40, 490),

			new MonsterLevelExpData(41, 500),

			new MonsterLevelExpData(42, 510),

			new MonsterLevelExpData(43, 520),

			new MonsterLevelExpData(44, 530),

			new MonsterLevelExpData(45, 540),

			new MonsterLevelExpData(46, 550),

			new MonsterLevelExpData(47, 560),

			new MonsterLevelExpData(48, 570),

			new MonsterLevelExpData(49, 580),

			new MonsterLevelExpData(50, 590),

		};

	}
}

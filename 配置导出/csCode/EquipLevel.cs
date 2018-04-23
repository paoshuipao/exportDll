
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class EquipLevelData : IConfig 
	{
		
		public int gold;

		public int rate;

		public int level;

		public EquipLevelData(int id1, int gold1, int rate1, int level1) 
		{
			
			id=id1;

			gold=gold1;

			rate=rate1;

			level=level1;

		}
	}

	public partial class GameData 
	{
		
		public static List<EquipLevelData> EquipLevel = new List<EquipLevelData>() 
		{
			
			new EquipLevelData(1, 0, 100, 1),

			new EquipLevelData(2, 100, 100, 5),

			new EquipLevelData(3, 200, 70, 10),

			new EquipLevelData(4, 300, 40, 15),

			new EquipLevelData(5, 400, 30, 20),

			new EquipLevelData(6, 500, 20, 25),

			new EquipLevelData(7, 600, 10, 30),

			new EquipLevelData(8, 700, 10, 35),

			new EquipLevelData(9, 800, 10, 40),

			new EquipLevelData(10, 900, 10, 45),

		};

	}
}

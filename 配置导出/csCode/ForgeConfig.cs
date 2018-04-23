
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class ForgeConfigData : IConfig 
	{
		
		public string name;

		public string materials;

		public int output;

		public int level;

		public ForgeConfigData(int id1, string name1, string materials1, int output1, int level1) 
		{
			
			id=id1;

			name=name1;

			materials=materials1;

			output=output1;

			level=level1;

		}
	}

	public partial class GameData 
	{
		
		public static List<ForgeConfigData> ForgeConfig = new List<ForgeConfigData>() 
		{
			
			new ForgeConfigData(1, "瀛洲刀", "{\"300\":5, \"301\":5, \"302\":5}", 101, 1),

			new ForgeConfigData(2, "瀛洲甲", "{\"300\":5, \"301\":5, \"302\":5}", 73, 1),

			new ForgeConfigData(3, "瀛洲手套", "{\"300\":5, \"301\":5, \"302\":5}", 74, 1),

			new ForgeConfigData(4, "瀛洲盔", "{\"300\":5, \"301\":5, \"302\":5}", 75, 1),

			new ForgeConfigData(5, "瀛洲靴", "{\"300\":5, \"301\":5, \"302\":5}", 76, 1),

			new ForgeConfigData(6, "瀛洲下身甲", "{\"300\":5, \"301\":5, \"302\":5}", 77, 1),

		};

	}
}


using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class ListBeanNameData : IConfig 
	{
		
		public string Name;

		public bool IsTrue;

		public string Icon;

		public long LongLong;

		public ListBeanNameData(int id1, string Name1, bool IsTrue1, string Icon1, long LongLong1) 
		{
			
			id=id1;

			Name=Name1;

			IsTrue=IsTrue1;

			Icon=Icon1;

			LongLong=LongLong1;

		}
		
		public override string ToString()
		{
			return "     注释行- "+id+"     使用string- "+Name+"     使用bool- "+IsTrue+"     使用图片即名- "+Icon+"     使用很长整数- "+LongLong;
		}

	}

	public partial class GameData 
	{
		
		public static List<ListBeanNameData> ListBeanName = new List<ListBeanNameData>() 
		{
			
			new ListBeanNameData(1, "abc", true, "icon_potion_mana_small", 11111111),

			new ListBeanNameData(2, "中文", true, "icon_potion_mana_small", 11111111),

			new ListBeanNameData(3, "中AB", true, "icon_potion_mana_small", 11111111),

			new ListBeanNameData(4, "中文", true, "icon_potion_mana_small", 1111111111111110),

			new ListBeanNameData(5, "400.0", true, "icon_potion_mana_small", 1111111111111110),

			new ListBeanNameData(6, "500.0", true, "icon_potion_mana_small", 1111111111111110),

			new ListBeanNameData(7, "600.0", true, "icon_potion_mana_small", 1111111111111110),

			new ListBeanNameData(8, "700.0", true, "icon_potion_mana_small", 1111111111111110),

			new ListBeanNameData(9, "800.0", false, "icon_potion_mana_small", 1111111111111110),

			new ListBeanNameData(10, "900.0", false, "icon_potion_mana_small", 1111111111111110),

		};

	}
}

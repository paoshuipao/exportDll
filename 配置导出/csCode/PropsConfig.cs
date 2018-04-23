
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class PropsConfigData : IConfig 
	{
		
		public string name;

		public int level;

		public int propsType;

		public int goldCoin;

		public int JingShi;

		public int sheet;

		public string icon;

		public string UserData;

		public string dropIcon;

		public int maxAmount;

		public bool canUse;

		public int triggerBuffId;

		public string description;

		public string attack;

		public string defense;

		public int rate;

		public PropsConfigData(int id1, string name1, int level1, int propsType1, int goldCoin1, int JingShi1, int sheet1, string icon1, string UserData1, string dropIcon1, int maxAmount1, bool canUse1, int triggerBuffId1, string description1, string attack1, string defense1, int rate1) 
		{
			
			id=id1;

			name=name1;

			level=level1;

			propsType=propsType1;

			goldCoin=goldCoin1;

			JingShi=JingShi1;

			sheet=sheet1;

			icon=icon1;

			UserData=UserData1;

			dropIcon=dropIcon1;

			maxAmount=maxAmount1;

			canUse=canUse1;

			triggerBuffId=triggerBuffId1;

			description=description1;

			attack=attack1;

			defense=defense1;

			rate=rate1;

		}
	}

	public partial class GameData 
	{
		
		public static List<PropsConfigData> PropsConfig = new List<PropsConfigData>() 
		{
			
			new PropsConfigData(1, "EXP", 1, 0, 0, 0, 7, "icon_potion_mana_small", "", "", 999, false, 0, "", "[1,2]", "", 100),

			new PropsConfigData(4, "金币", 1, 12, 0, 0, 9, "ember_gleaming", "", "models/gold", 999, false, 0, "", "", "[1,2]", 100),

			new PropsConfigData(101, "凝心草", 1, 1, 20, 0, 0, "icon_potion_health_small", "", "models/items/potion", 999, true, 103, "华夏大陆神秘药草,可通奇经八脉", "", "", 0),

			new PropsConfigData(102, "荡魔卷轴", 1, 0, 1000, 0, 0, "icon_potion_health_small", "", "models/items/potion", 999, true, 0, "强大法力所炼制可破除魔神巢穴结界的符咒，巨牙子村长拥有此种法力", "", "", 0),

			new PropsConfigData(200, "神武打造图", 1, 16, 1000, 0, 0, "icon_potion_health_small", "8.0", "models/items/quest_bag", 999, true, 0, "此图记录的远古神兵的制作方法，唯天妒之人方能习得", "", "", 0),

			new PropsConfigData(201, "魔甲打造图", 1, 16, 1000, 0, 0, "icon_potion_health_small", "7.0", "models/items/quest_bag", 999, true, 0, "此图记录的远古神兵的制作方法，唯天妒之人方能习得", "", "", 0),

			new PropsConfigData(202, "手套打造图", 1, 16, 1000, 0, 0, "icon_potion_health_small", "4.0", "models/items/quest_bag", 999, true, 0, "此图记录的远古神兵的制作方法，唯天妒之人方能习得", "", "", 0),

			new PropsConfigData(203, "头盔打造图", 1, 16, 1000, 0, 0, "icon_potion_health_small", "1.0", "models/items/quest_bag", 999, true, 0, "此图记录的远古神兵的制作方法，唯天妒之人方能习得", "", "", 0),

			new PropsConfigData(204, "战靴打造图", 1, 16, 1000, 0, 0, "icon_potion_health_small", "3.0", "models/items/quest_bag", 999, true, 0, "此图记录的远古神兵的制作方法，唯天妒之人方能习得", "", "", 0),

			new PropsConfigData(205, "绑腿打造图", 1, 16, 1000, 0, 0, "icon_potion_health_small", "2.0", "models/items/quest_bag", 999, true, 0, "此图记录的远古神兵的制作方法，唯天妒之人方能习得", "", "", 0),

			new PropsConfigData(300, "爆裂法师之铁", 1, 13, 0, 10, 0, "icon_potion_health_small", "", "models/items/quest_bag", 999, true, 0, "神庙中爆裂法师的核心机构，乃天工所造", "", "", 0),

			new PropsConfigData(301, "狼骨", 1, 13, 0, 10, 0, "icon_potion_health_small", "", "models/items/quest_bag", 999, true, 0, "神庙狼胸骨，经冥火淬炼，坚韧无比", "", "", 0),

			new PropsConfigData(302, "蝙蝠魂", 1, 13, 0, 10, 0, "icon_potion_health_small", "", "models/items/quest_bag", 999, true, 0, "神庙蝙蝠死后精魂凝聚，常有魔音外泄", "", "", 0),

			new PropsConfigData(5, "晶石", 1, 12, 0, 0, 9, "ember_gleaming", "", "models/gold", 999, false, 0, "", "", "[1,2]", 100),

			new PropsConfigData(401, "炼狱龟甲", 1, 4, 0, 100, 9, "ember_gleaming", "143.0", "models/items/quest_bag", 999, true, 0, "神秘龟甲，上面记录了一些古老文字，散发着洪荒之气", "", "[1,2]", 100),

			new PropsConfigData(6, "苍冥水", 1, 9, 0, 0, 9, "ember_gleaming", "", "models/items/quest_bag", 999, false, 0, "苍冥狼乳汁所化的神水，乃苍冥狼性命攸关之物", "", "[1,2]", 100),

			new PropsConfigData(1000, "顽石", 1, 2, 0, 1, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "小怪们喜欢随手把玩活动手指的石头", "[1,2]", "", 100),

			new PropsConfigData(1001, "土块", 1, 2, 0, 1, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "洞穴里捡到的泥土块", "", "[1,2]", 100),

			new PropsConfigData(1002, "紫晶", 2, 2, 0, 2, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "冰寒之力所凝聚宝石", "[1,2]", "", 30),

			new PropsConfigData(1003, "翡翠", 2, 2, 0, 2, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "自然之力所凝聚宝石", "", "[1,2]", 30),

			new PropsConfigData(1004, "蜜蜡", 2, 2, 0, 3, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "蜜蜂采百花所凝聚宝石", "[1,2]", "[1,2]", 10),

			new PropsConfigData(1005, "蓝晶", 3, 2, 0, 4, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "幽冥之力凝聚的宝石", "[1,2]", "", 25),

			new PropsConfigData(1006, "鸡血", 3, 2, 0, 4, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "传说屠戮千只凤凰鲜血凝聚之物", "", "[1,2]", 25),

			new PropsConfigData(1007, "田黄", 3, 2, 0, 5, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "幽冥界生长之神草所炼制之物", "[1,2]", "[1,2]", 10),

			new PropsConfigData(1008, "七杀星", 4, 2, 0, 8, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "神将所化星辰", "[1,2]", "", 20),

			new PropsConfigData(1009, "破军星", 4, 2, 0, 8, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "纣王所化星辰", "", "[1,2]", 20),

			new PropsConfigData(1010, "贪狼星", 4, 2, 0, 10, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "众生贪念所凝聚之星辰", "[1,2]", "[1,2]", 10),

			new PropsConfigData(1011, "少阳珠", 5, 2, 0, 16, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "取五百童男炼制此珠", "[1,2]", "", 15),

			new PropsConfigData(1012, "少阴珠", 5, 2, 0, 16, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "取五百童女炼制此珠", "", "[1,2]", 15),

			new PropsConfigData(1013, "阴阳珠", 5, 2, 0, 20, 7, "icon_potion_mana_small", "", "models/items/quest_bag", 999, false, 0, "焚童男童女聚其魂魄凝练此珠", "[1,2]", "[1,2]", 5),

		};

	}
}

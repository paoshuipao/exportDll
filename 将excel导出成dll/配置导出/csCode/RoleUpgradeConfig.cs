﻿
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class RoleUpgradeConfigData : IConfig 
	{
		
		public int level;

		public int job;

		public long exp;

		public int maxHp;

		public int maxMp;

		public int power;

		public int energy;

		public int fightingWill;

		public int physique;

		public int constitution;

		public int gail;

		public int precise;

		public int block;

		public int attack;

		public int defense;

		public int hit;

		public int dodge;

		public int critical;

		public int criticalDefense;

		public int waterAttack;

		public int fireAttack;

		public int windAttack;

		public int soilAttack;

		public int antiWater;

		public int antiFire;

		public int antiWind;

		public int antiSoil;

		public int skillPoint;

		public RoleUpgradeConfigData(int id1, int level1, int job1, long exp1, int maxHp1, int maxMp1, int power1, int energy1, int fightingWill1, int physique1, int constitution1, int gail1, int precise1, int block1, int attack1, int defense1, int hit1, int dodge1, int critical1, int criticalDefense1, int waterAttack1, int fireAttack1, int windAttack1, int soilAttack1, int antiWater1, int antiFire1, int antiWind1, int antiSoil1, int skillPoint1) 
		{
			
			id=id1;

			level=level1;

			job=job1;

			exp=exp1;

			maxHp=maxHp1;

			maxMp=maxMp1;

			power=power1;

			energy=energy1;

			fightingWill=fightingWill1;

			physique=physique1;

			constitution=constitution1;

			gail=gail1;

			precise=precise1;

			block=block1;

			attack=attack1;

			defense=defense1;

			hit=hit1;

			dodge=dodge1;

			critical=critical1;

			criticalDefense=criticalDefense1;

			waterAttack=waterAttack1;

			fireAttack=fireAttack1;

			windAttack=windAttack1;

			soilAttack=soilAttack1;

			antiWater=antiWater1;

			antiFire=antiFire1;

			antiWind=antiWind1;

			antiSoil=antiSoil1;

			skillPoint=skillPoint1;

		}
		
		public override string ToString()
		{
			return "     ID- "+id+"     等级- "+level+"     职业- "+job+"     升级经验- "+exp+"     生命- "+maxHp+"     魔法- "+maxMp+"     体力- "+power+"     活力- "+energy+"     斗志- "+fightingWill+"     筋骨- "+physique+"     体魄- "+constitution+"     身法- "+gail+"     精准- "+precise+"     格挡- "+block+"     攻击- "+attack+"     防御- "+defense+"     命中- "+hit+"     闪避- "+dodge+"     会心- "+critical+"     会心防御- "+criticalDefense+"     水攻- "+waterAttack+"     火攻- "+fireAttack+"     风攻- "+windAttack+"     土攻- "+soilAttack+"     抗水- "+antiWater+"     抗火- "+antiFire+"     抗风- "+antiWind+"     抗土- "+antiSoil+"     增加技能点- "+skillPoint;
		}

	}

	public partial class GameData 
	{
		
		public static List<RoleUpgradeConfigData> RoleUpgradeConfig = new List<RoleUpgradeConfigData>() 
		{
			
			new RoleUpgradeConfigData(10001, 1, 1, 4800, 130, 80, 100, 100, 10, 5, 4, 3, 2, 100, 13, 0, 48, 500, 800, 2200, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10002, 2, 1, 5600, 150, 90, 100, 100, 11, 6, 5, 4, 3, 100, 14, 0, 73, 538, 813, 2376, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10003, 3, 1, 6400, 170, 100, 100, 100, 12, 7, 6, 5, 4, 100, 15, 0, 98, 500, 826, 2552, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10004, 4, 1, 7200, 190, 110, 100, 100, 13, 8, 7, 6, 5, 100, 16, 0, 123, 539, 839, 2728, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10005, 5, 1, 8000, 210, 120, 100, 100, 14, 9, 8, 7, 6, 100, 17, 0, 148, 500, 852, 2904, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10006, 6, 1, 9600, 230, 130, 100, 100, 15, 10, 9, 8, 7, 100, 18, 0, 173, 540, 865, 3080, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10007, 7, 1, 11200, 250, 140, 100, 100, 16, 11, 10, 9, 8, 100, 19, 0, 198, 500, 878, 3256, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10008, 8, 1, 12800, 270, 150, 100, 100, 17, 12, 11, 10, 9, 100, 20, 0, 223, 541, 891, 3432, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10009, 9, 1, 14400, 290, 160, 100, 100, 18, 13, 12, 11, 10, 100, 21, 0, 248, 500, 904, 3608, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10010, 10, 1, 16000, 310, 170, 100, 100, 19, 14, 13, 12, 11, 100, 22, 0, 273, 542, 917, 3784, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10011, 11, 1, 19200, 330, 180, 100, 100, 20, 15, 14, 13, 12, 100, 23, 0, 298, 500, 930, 3960, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10012, 12, 1, 22400, 350, 190, 100, 100, 21, 16, 15, 14, 13, 100, 24, 0, 323, 543, 943, 4136, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10013, 13, 1, 25600, 370, 200, 100, 100, 22, 17, 16, 15, 14, 100, 25, 0, 348, 500, 956, 4312, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10014, 14, 1, 28800, 390, 210, 100, 100, 23, 18, 17, 16, 15, 100, 26, 0, 373, 544, 969, 4488, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10015, 15, 1, 32000, 410, 220, 100, 100, 24, 19, 18, 17, 16, 100, 27, 0, 398, 500, 982, 4664, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10016, 16, 1, 38400, 430, 230, 100, 100, 25, 20, 19, 18, 17, 100, 28, 0, 423, 545, 995, 4840, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10017, 17, 1, 44800, 450, 240, 100, 100, 26, 21, 20, 19, 18, 100, 29, 0, 448, 500, 1008, 5016, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10018, 18, 1, 51200, 470, 250, 100, 100, 27, 22, 21, 20, 19, 100, 30, 0, 473, 546, 1021, 5192, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10019, 19, 1, 57600, 490, 260, 100, 100, 28, 23, 22, 21, 20, 100, 31, 0, 498, 500, 1034, 5368, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10020, 20, 1, 64000, 510, 270, 100, 100, 29, 24, 23, 22, 21, 100, 32, 0, 523, 547, 1047, 5544, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10021, 21, 1, 76800, 530, 280, 100, 100, 30, 25, 24, 23, 22, 100, 33, 0, 548, 500, 1060, 5720, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10022, 22, 1, 89600, 550, 290, 100, 100, 31, 26, 25, 24, 23, 100, 34, 0, 573, 548, 1073, 5896, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10023, 23, 1, 102400, 570, 300, 100, 100, 32, 27, 26, 25, 24, 100, 35, 0, 598, 500, 1086, 6072, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10024, 24, 1, 115200, 590, 310, 100, 100, 33, 28, 27, 26, 25, 100, 36, 0, 623, 549, 1099, 6248, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10025, 25, 1, 128000, 610, 320, 100, 100, 34, 29, 28, 27, 26, 100, 37, 0, 648, 500, 1112, 6424, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10026, 26, 1, 153600, 630, 330, 100, 100, 35, 30, 29, 28, 27, 100, 38, 0, 673, 550, 1125, 6600, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10027, 27, 1, 179200, 650, 340, 100, 100, 36, 31, 30, 29, 28, 100, 39, 0, 698, 500, 1138, 6776, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10028, 28, 1, 204800, 670, 350, 100, 100, 37, 32, 31, 30, 29, 100, 40, 0, 723, 551, 1151, 6952, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10029, 29, 1, 230400, 690, 360, 100, 100, 38, 33, 32, 31, 30, 100, 41, 0, 748, 500, 1164, 7128, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10030, 30, 1, 256000, 710, 370, 100, 100, 39, 34, 33, 32, 31, 100, 42, 0, 773, 552, 1177, 7304, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10031, 31, 1, 307200, 730, 380, 100, 100, 40, 35, 34, 33, 32, 100, 43, 0, 798, 500, 1190, 7480, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10032, 32, 1, 358400, 750, 390, 100, 100, 41, 36, 35, 34, 33, 100, 44, 0, 823, 553, 1203, 7656, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10033, 33, 1, 409600, 770, 400, 100, 100, 42, 37, 36, 35, 34, 100, 45, 0, 848, 500, 1216, 7832, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10034, 34, 1, 460800, 790, 410, 100, 100, 43, 38, 37, 36, 35, 100, 46, 0, 873, 554, 1229, 8008, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10035, 35, 1, 512000, 810, 420, 100, 100, 44, 39, 38, 37, 36, 100, 47, 0, 898, 500, 1242, 8184, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10036, 36, 1, 614400, 830, 430, 100, 100, 45, 40, 39, 38, 37, 100, 48, 0, 923, 555, 1255, 8360, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10037, 37, 1, 716800, 850, 440, 100, 100, 46, 41, 40, 39, 38, 100, 49, 0, 948, 500, 1268, 8536, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10038, 38, 1, 819200, 870, 450, 100, 100, 47, 42, 41, 40, 39, 100, 50, 0, 973, 556, 1281, 8712, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10039, 39, 1, 921600, 890, 460, 100, 100, 48, 43, 42, 41, 40, 100, 51, 0, 998, 500, 1294, 8888, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10040, 40, 1, 1024000, 910, 470, 100, 100, 49, 44, 43, 42, 41, 100, 52, 0, 1023, 557, 1307, 9064, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10041, 41, 1, 1228800, 930, 480, 100, 100, 50, 45, 44, 43, 42, 100, 53, 0, 1048, 500, 1320, 9240, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10042, 42, 1, 1433600, 950, 490, 100, 100, 51, 46, 45, 44, 43, 100, 54, 0, 1073, 558, 1333, 9416, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10043, 43, 1, 1638400, 970, 500, 100, 100, 52, 47, 46, 45, 44, 100, 55, 0, 1098, 500, 1346, 9592, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10044, 44, 1, 1843200, 990, 510, 100, 100, 53, 48, 47, 46, 45, 100, 56, 0, 1123, 559, 1359, 9768, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10045, 45, 1, 2048000, 1010, 520, 100, 100, 54, 49, 48, 47, 46, 100, 57, 0, 1148, 500, 1372, 9944, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10046, 46, 1, 2457600, 1030, 530, 100, 100, 55, 50, 49, 48, 47, 100, 58, 0, 1173, 560, 1385, 10120, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10047, 47, 1, 2867200, 1050, 540, 100, 100, 56, 51, 50, 49, 48, 100, 59, 0, 1198, 500, 1398, 10296, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10048, 48, 1, 3276800, 1070, 550, 100, 100, 57, 52, 51, 50, 49, 100, 60, 0, 1223, 561, 1411, 10472, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10049, 49, 1, 3686400, 1090, 560, 100, 100, 58, 53, 52, 51, 50, 100, 61, 0, 1248, 500, 1424, 10648, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(10050, 50, 1, 4096000, 1110, 570, 100, 100, 59, 54, 53, 52, 51, 100, 62, 0, 1273, 562, 1437, 10824, 0, 0, 0, 0, -10, 10, 0, 0, 2),

			new RoleUpgradeConfigData(20001, 1, 2, 4000, 130, 80, 100, 100, 11, 4, 3, 3, 3, 100, 13, 0, 4800, 500, 800, 2200, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20002, 2, 2, 9412, 135, 90, 100, 100, 12, 5, 4, 4, 4, 100, 14, 0, 7354, 747, 818, 2447, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20003, 3, 2, 17404, 140, 100, 100, 100, 13, 6, 5, 5, 5, 100, 15, 0, 9908, 994, 836, 2694, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20004, 4, 2, 28246, 145, 110, 100, 100, 14, 7, 6, 6, 6, 100, 16, 0, 12462, 1241, 854, 2941, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20005, 5, 2, 42022, 150, 120, 100, 100, 15, 8, 7, 7, 7, 100, 17, 0, 15016, 1488, 872, 3188, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20006, 6, 2, 58942, 155, 130, 100, 100, 16, 9, 8, 8, 8, 100, 18, 0, 17570, 1735, 890, 3435, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20007, 7, 2, 79102, 160, 140, 100, 100, 17, 10, 9, 9, 9, 100, 19, 0, 20124, 1982, 908, 3682, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20008, 8, 2, 108569, 165, 150, 100, 100, 18, 11, 10, 10, 10, 100, 20, 0, 22678, 2229, 926, 3929, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20009, 9, 2, 131231, 170, 160, 100, 100, 19, 12, 11, 11, 11, 100, 21, 0, 25232, 2476, 944, 4176, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20010, 10, 2, 157972, 175, 170, 100, 100, 20, 13, 12, 12, 12, 100, 22, 0, 27786, 2723, 962, 4423, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20011, 11, 2, 188832, 180, 180, 100, 100, 21, 14, 13, 13, 13, 100, 23, 0, 30340, 2970, 980, 4670, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20012, 12, 2, 223852, 185, 190, 100, 100, 22, 15, 14, 14, 14, 100, 24, 0, 32894, 3217, 998, 4917, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20013, 13, 2, 263071, 190, 200, 100, 100, 23, 16, 15, 15, 15, 100, 25, 0, 35448, 3464, 1016, 5164, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20014, 14, 2, 306531, 195, 210, 100, 100, 24, 17, 16, 16, 16, 100, 26, 0, 38002, 3711, 1034, 5411, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20015, 15, 2, 354270, 200, 220, 100, 100, 25, 18, 17, 17, 17, 100, 27, 0, 40556, 3958, 1052, 5658, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20016, 16, 2, 406330, 205, 230, 100, 100, 26, 19, 18, 18, 18, 100, 28, 0, 43110, 4205, 1070, 5905, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20017, 17, 2, 462749, 210, 240, 100, 100, 27, 20, 19, 19, 19, 100, 29, 0, 45664, 4452, 1088, 6152, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20018, 18, 2, 523570, 215, 250, 100, 100, 28, 21, 20, 20, 20, 100, 30, 0, 48218, 4699, 1106, 6399, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20019, 19, 2, 588830, 220, 260, 100, 100, 29, 22, 21, 21, 21, 100, 31, 0, 50772, 4946, 1124, 6646, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20020, 20, 2, 658572, 225, 270, 100, 100, 30, 23, 22, 22, 22, 100, 32, 0, 53326, 5193, 1142, 6893, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20021, 21, 2, 732834, 230, 280, 100, 100, 31, 24, 23, 23, 23, 100, 33, 0, 55880, 5440, 1160, 7140, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20022, 22, 2, 811657, 235, 290, 100, 100, 32, 25, 24, 24, 24, 100, 34, 0, 58434, 5687, 1178, 7387, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20023, 23, 2, 895081, 240, 300, 100, 100, 33, 26, 25, 25, 25, 100, 35, 0, 60988, 5934, 1196, 7634, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20024, 24, 2, 983146, 245, 310, 100, 100, 34, 27, 26, 26, 26, 100, 36, 0, 63542, 6181, 1214, 7881, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20025, 25, 2, 1075893, 250, 320, 100, 100, 35, 28, 27, 27, 27, 100, 37, 0, 66096, 6428, 1232, 8128, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20026, 26, 2, 1173361, 255, 330, 100, 100, 36, 29, 28, 28, 28, 100, 38, 0, 68650, 6675, 1250, 8375, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20027, 27, 2, 1275591, 260, 340, 100, 100, 37, 30, 29, 29, 29, 100, 39, 0, 71204, 6922, 1268, 8622, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20028, 28, 2, 1382622, 265, 350, 100, 100, 38, 31, 30, 30, 30, 100, 40, 0, 73758, 7169, 1286, 8869, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20029, 29, 2, 1494496, 270, 360, 100, 100, 39, 32, 31, 31, 31, 100, 41, 0, 76312, 7416, 1304, 9116, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20030, 30, 2, 1611252, 275, 370, 100, 100, 40, 33, 32, 32, 32, 100, 42, 0, 78866, 7663, 1322, 9363, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20031, 31, 2, 1732929, 280, 380, 100, 100, 41, 34, 33, 33, 33, 100, 43, 0, 81420, 7910, 1340, 9610, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20032, 32, 2, 1859569, 285, 390, 100, 100, 42, 35, 34, 34, 34, 100, 44, 0, 83974, 8157, 1358, 9857, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20033, 33, 2, 1991212, 290, 400, 100, 100, 43, 36, 35, 35, 35, 100, 45, 0, 86528, 8404, 1376, 10104, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20034, 34, 2, 2127897, 295, 410, 100, 100, 44, 37, 36, 36, 36, 100, 46, 0, 89082, 8651, 1394, 10351, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20035, 35, 2, 2269665, 300, 420, 100, 100, 45, 38, 37, 37, 37, 100, 47, 0, 91636, 8898, 1412, 10598, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20036, 36, 2, 2416556, 305, 430, 100, 100, 46, 39, 38, 38, 38, 100, 48, 0, 94190, 9145, 1430, 10845, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20037, 37, 2, 2568610, 310, 440, 100, 100, 47, 40, 39, 39, 39, 100, 49, 0, 96744, 9392, 1448, 11092, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20038, 38, 2, 2725867, 315, 450, 100, 100, 48, 41, 40, 40, 40, 100, 50, 0, 99298, 9639, 1466, 11339, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20039, 39, 2, 2888368, 320, 460, 100, 100, 49, 42, 41, 41, 41, 100, 51, 0, 101852, 9886, 1484, 11586, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20040, 40, 2, 3056152, 325, 470, 100, 100, 50, 43, 42, 42, 42, 100, 52, 0, 104406, 10133, 1502, 11833, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20041, 41, 2, 3229259, 330, 480, 100, 100, 51, 44, 43, 43, 43, 100, 53, 0, 106960, 10380, 1520, 12080, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20042, 42, 2, 3407730, 335, 490, 100, 100, 52, 45, 44, 44, 44, 100, 54, 0, 109514, 10627, 1538, 12327, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20043, 43, 2, 3591605, 340, 500, 100, 100, 53, 46, 45, 45, 45, 100, 55, 0, 112068, 10874, 1556, 12574, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20044, 44, 2, 3780924, 345, 510, 100, 100, 54, 47, 46, 46, 46, 100, 56, 0, 114622, 11121, 1574, 12821, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20045, 45, 2, 3975728, 350, 520, 100, 100, 55, 48, 47, 47, 47, 100, 57, 0, 117176, 11368, 1592, 13068, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20046, 46, 2, 4176055, 355, 530, 100, 100, 56, 49, 48, 48, 48, 100, 58, 0, 119730, 11615, 1610, 13315, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20047, 47, 2, 4381947, 360, 540, 100, 100, 57, 50, 49, 49, 49, 100, 59, 0, 122284, 11862, 1628, 13562, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20048, 48, 2, 4593444, 365, 550, 100, 100, 58, 51, 50, 50, 50, 100, 60, 0, 124838, 12109, 1646, 13809, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20049, 49, 2, 4810585, 370, 560, 100, 100, 59, 52, 51, 51, 51, 100, 61, 0, 127392, 12356, 1664, 14056, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(20050, 50, 2, 5033412, 375, 570, 100, 100, 60, 53, 52, 52, 52, 100, 62, 0, 129946, 12603, 1682, 14303, 0, 0, 0, 0, 0, 5, 20, 0, 2),

			new RoleUpgradeConfigData(30001, 1, 3, 4000, 76, 80, 100, 100, 13, 2, 3, 3, 3, 100, 10, 0, 4800, 500, 800, 2200, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30002, 2, 3, 9412, 89, 90, 100, 100, 14, 3, 4, 4, 4, 100, 11, 0, 7420, 546, 920, 2378, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30003, 3, 3, 17404, 102, 100, 100, 100, 15, 4, 5, 5, 5, 100, 12, 0, 10040, 592, 1040, 2556, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30004, 4, 3, 28246, 115, 110, 100, 100, 16, 5, 6, 6, 6, 100, 13, 0, 12660, 638, 1160, 2734, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30005, 5, 3, 42022, 128, 120, 100, 100, 17, 6, 7, 7, 7, 100, 14, 0, 15280, 684, 1280, 2912, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30006, 6, 3, 58942, 141, 130, 100, 100, 18, 7, 8, 8, 8, 100, 15, 0, 17900, 730, 1400, 3090, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30007, 7, 3, 79102, 154, 140, 100, 100, 19, 8, 9, 9, 9, 100, 16, 0, 20520, 776, 1520, 3268, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30008, 8, 3, 108569, 167, 150, 100, 100, 20, 9, 10, 10, 10, 100, 17, 0, 23140, 822, 1640, 3446, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30009, 9, 3, 131231, 180, 160, 100, 100, 21, 10, 11, 11, 11, 100, 18, 0, 25760, 868, 1760, 3624, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30010, 10, 3, 157972, 193, 170, 100, 100, 22, 11, 12, 12, 12, 100, 19, 0, 28380, 914, 1880, 3802, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30011, 11, 3, 188832, 206, 180, 100, 100, 23, 12, 13, 13, 13, 100, 20, 0, 31000, 960, 2000, 3980, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30012, 12, 3, 223852, 219, 190, 100, 100, 24, 13, 14, 14, 14, 100, 21, 0, 33620, 1006, 2120, 4158, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30013, 13, 3, 263071, 232, 200, 100, 100, 25, 14, 15, 15, 15, 100, 22, 0, 36240, 1052, 2240, 4336, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30014, 14, 3, 306531, 245, 210, 100, 100, 26, 15, 16, 16, 16, 100, 23, 0, 38860, 1098, 2360, 4514, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30015, 15, 3, 354270, 258, 220, 100, 100, 27, 16, 17, 17, 17, 100, 24, 0, 41480, 1144, 2480, 4692, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30016, 16, 3, 406330, 271, 230, 100, 100, 28, 17, 18, 18, 18, 100, 25, 0, 44100, 1190, 2600, 4870, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30017, 17, 3, 462749, 284, 240, 100, 100, 29, 18, 19, 19, 19, 100, 26, 0, 46720, 1236, 2720, 5048, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30018, 18, 3, 523570, 297, 250, 100, 100, 30, 19, 20, 20, 20, 100, 27, 0, 49340, 1282, 2840, 5226, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30019, 19, 3, 588830, 310, 260, 100, 100, 31, 20, 21, 21, 21, 100, 28, 0, 51960, 1328, 2960, 5404, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30020, 20, 3, 658572, 323, 270, 100, 100, 32, 21, 22, 22, 22, 100, 29, 0, 54580, 1374, 3080, 5582, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30021, 21, 3, 732834, 336, 280, 100, 100, 33, 22, 23, 23, 23, 100, 30, 0, 57200, 1420, 3200, 5760, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30022, 22, 3, 811657, 349, 290, 100, 100, 34, 23, 24, 24, 24, 100, 31, 0, 59820, 1466, 3320, 5938, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30023, 23, 3, 895081, 362, 300, 100, 100, 35, 24, 25, 25, 25, 100, 32, 0, 62440, 1512, 3440, 6116, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30024, 24, 3, 983146, 375, 310, 100, 100, 36, 25, 26, 26, 26, 100, 33, 0, 65060, 1558, 3560, 6294, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30025, 25, 3, 1075893, 388, 320, 100, 100, 37, 26, 27, 27, 27, 100, 34, 0, 67680, 1604, 3680, 6472, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30026, 26, 3, 1173361, 401, 330, 100, 100, 38, 27, 28, 28, 28, 100, 35, 0, 70300, 1650, 3800, 6650, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30027, 27, 3, 1275591, 414, 340, 100, 100, 39, 28, 29, 29, 29, 100, 36, 0, 72920, 1696, 3920, 6828, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30028, 28, 3, 1382622, 427, 350, 100, 100, 40, 29, 30, 30, 30, 100, 37, 0, 75540, 1742, 4040, 7006, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30029, 29, 3, 1494496, 440, 360, 100, 100, 41, 30, 31, 31, 31, 100, 38, 0, 78160, 1788, 4160, 7184, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30030, 30, 3, 1611252, 453, 370, 100, 100, 42, 31, 32, 32, 32, 100, 39, 0, 80780, 1834, 4280, 7362, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30031, 31, 3, 1732929, 466, 380, 100, 100, 43, 32, 33, 33, 33, 100, 40, 0, 83400, 1880, 4400, 7540, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30032, 32, 3, 1859569, 479, 390, 100, 100, 44, 33, 34, 34, 34, 100, 41, 0, 86020, 1926, 4520, 7718, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30033, 33, 3, 1991212, 492, 400, 100, 100, 45, 34, 35, 35, 35, 100, 42, 0, 88640, 1972, 4640, 7896, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30034, 34, 3, 2127897, 505, 410, 100, 100, 46, 35, 36, 36, 36, 100, 43, 0, 91260, 2018, 4760, 8074, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30035, 35, 3, 2269665, 518, 420, 100, 100, 47, 36, 37, 37, 37, 100, 44, 0, 93880, 2064, 4880, 8252, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30036, 36, 3, 2416556, 531, 430, 100, 100, 48, 37, 38, 38, 38, 100, 45, 0, 96500, 2110, 5000, 8430, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30037, 37, 3, 2568610, 544, 440, 100, 100, 49, 38, 39, 39, 39, 100, 46, 0, 99120, 2156, 5120, 8608, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30038, 38, 3, 2725867, 557, 450, 100, 100, 50, 39, 40, 40, 40, 100, 47, 0, 101740, 2202, 5240, 8786, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30039, 39, 3, 2888368, 570, 460, 100, 100, 51, 40, 41, 41, 41, 100, 48, 0, 104360, 2248, 5360, 8964, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30040, 40, 3, 3056152, 583, 470, 100, 100, 52, 41, 42, 42, 42, 100, 49, 0, 106980, 2294, 5480, 9142, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30041, 41, 3, 3229259, 596, 480, 100, 100, 53, 42, 43, 43, 43, 100, 50, 0, 109600, 2340, 5600, 9320, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30042, 42, 3, 3407730, 609, 490, 100, 100, 54, 43, 44, 44, 44, 100, 51, 0, 112220, 2386, 5720, 9498, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30043, 43, 3, 3591605, 622, 500, 100, 100, 55, 44, 45, 45, 45, 100, 52, 0, 114840, 2432, 5840, 9676, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30044, 44, 3, 3780924, 635, 510, 100, 100, 56, 45, 46, 46, 46, 100, 53, 0, 117460, 2478, 5960, 9854, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30045, 45, 3, 3975728, 648, 520, 100, 100, 57, 46, 47, 47, 47, 100, 54, 0, 120080, 2524, 6080, 10032, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30046, 46, 3, 4176055, 661, 530, 100, 100, 58, 47, 48, 48, 48, 100, 55, 0, 122700, 2570, 6200, 10210, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30047, 47, 3, 4381947, 674, 540, 100, 100, 59, 48, 49, 49, 49, 100, 56, 0, 125320, 2616, 6320, 10388, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30048, 48, 3, 4593444, 687, 550, 100, 100, 60, 49, 50, 50, 50, 100, 57, 0, 127940, 2662, 6440, 10566, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30049, 49, 3, 4810585, 700, 560, 100, 100, 61, 50, 51, 51, 51, 100, 58, 0, 130560, 2708, 6560, 10744, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(30050, 50, 3, 5033412, 713, 570, 100, 100, 62, 51, 52, 52, 52, 100, 59, 0, 133180, 2754, 6680, 10922, 0, 0, 0, 0, 10, 10, 10, -10, 2),

			new RoleUpgradeConfigData(40001, 1, 4, 4000, 130, 80, 100, 100, 12, 4, 2, 3, 3, 100, 13, 0, 48, 500, 800, 2200, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40002, 2, 4, 9412, 140, 90, 100, 100, 13, 5, 3, 4, 4, 100, 15, 0, 74, 520, 850, 2380, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40003, 3, 4, 17404, 150, 100, 100, 100, 14, 6, 4, 5, 5, 100, 17, 0, 100, 540, 900, 2560, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40004, 4, 4, 28246, 160, 110, 100, 100, 15, 7, 5, 6, 6, 100, 19, 0, 126, 560, 950, 2740, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40005, 5, 4, 42022, 170, 120, 100, 100, 16, 8, 6, 7, 7, 100, 21, 0, 152, 580, 1000, 2920, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40006, 6, 4, 58942, 180, 130, 100, 100, 17, 9, 7, 8, 8, 100, 23, 0, 178, 600, 1050, 3100, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40007, 7, 4, 79102, 190, 140, 100, 100, 18, 10, 8, 9, 9, 100, 25, 0, 204, 620, 1100, 3280, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40008, 8, 4, 108569, 200, 150, 100, 100, 19, 11, 9, 10, 10, 100, 27, 0, 230, 640, 1150, 3460, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40009, 9, 4, 131231, 210, 160, 100, 100, 20, 12, 10, 11, 11, 100, 29, 0, 256, 660, 1200, 3640, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40010, 10, 4, 157972, 220, 170, 100, 100, 21, 13, 11, 12, 12, 100, 31, 0, 282, 680, 1250, 3820, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40011, 11, 4, 188832, 230, 180, 100, 100, 22, 14, 12, 13, 13, 100, 33, 0, 308, 700, 1300, 4000, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40012, 12, 4, 223852, 240, 190, 100, 100, 23, 15, 13, 14, 14, 100, 35, 0, 334, 720, 1350, 4180, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40013, 13, 4, 263071, 250, 200, 100, 100, 24, 16, 14, 15, 15, 100, 37, 0, 360, 740, 1400, 4360, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40014, 14, 4, 306531, 260, 210, 100, 100, 25, 17, 15, 16, 16, 100, 39, 0, 386, 760, 1450, 4540, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40015, 15, 4, 354270, 270, 220, 100, 100, 26, 18, 16, 17, 17, 100, 41, 0, 412, 780, 1500, 4720, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40016, 16, 4, 406330, 280, 230, 100, 100, 27, 19, 17, 18, 18, 100, 43, 0, 438, 800, 1550, 4900, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40017, 17, 4, 462749, 290, 240, 100, 100, 28, 20, 18, 19, 19, 100, 45, 0, 464, 820, 1600, 5080, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40018, 18, 4, 523570, 300, 250, 100, 100, 29, 21, 19, 20, 20, 100, 47, 0, 490, 840, 1650, 5260, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40019, 19, 4, 588830, 310, 260, 100, 100, 30, 22, 20, 21, 21, 100, 49, 0, 516, 860, 1700, 5440, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40020, 20, 4, 658572, 320, 270, 100, 100, 31, 23, 21, 22, 22, 100, 51, 0, 542, 880, 1750, 5620, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40021, 21, 4, 732834, 330, 280, 100, 100, 32, 24, 22, 23, 23, 100, 53, 0, 568, 900, 1800, 5800, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40022, 22, 4, 811657, 340, 290, 100, 100, 33, 25, 23, 24, 24, 100, 55, 0, 594, 920, 1850, 5980, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40023, 23, 4, 895081, 350, 300, 100, 100, 34, 26, 24, 25, 25, 100, 57, 0, 620, 940, 1900, 6160, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40024, 24, 4, 983146, 360, 310, 100, 100, 35, 27, 25, 26, 26, 100, 59, 0, 646, 960, 1950, 6340, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40025, 25, 4, 1075893, 370, 320, 100, 100, 36, 28, 26, 27, 27, 100, 61, 0, 672, 980, 2000, 6520, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40026, 26, 4, 1173361, 380, 330, 100, 100, 37, 29, 27, 28, 28, 100, 63, 0, 698, 1000, 2050, 6700, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40027, 27, 4, 1275591, 390, 340, 100, 100, 38, 30, 28, 29, 29, 100, 65, 0, 724, 1020, 2100, 6880, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40028, 28, 4, 1382622, 400, 350, 100, 100, 39, 31, 29, 30, 30, 100, 67, 0, 750, 1040, 2150, 7060, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40029, 29, 4, 1494496, 410, 360, 100, 100, 40, 32, 30, 31, 31, 100, 69, 0, 776, 1060, 2200, 7240, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40030, 30, 4, 1611252, 420, 370, 100, 100, 41, 33, 31, 32, 32, 100, 71, 0, 802, 1080, 2250, 7420, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40031, 31, 4, 1732929, 430, 380, 100, 100, 42, 34, 32, 33, 33, 100, 73, 0, 828, 1100, 2300, 7600, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40032, 32, 4, 1859569, 440, 390, 100, 100, 43, 35, 33, 34, 34, 100, 75, 0, 854, 1120, 2350, 7780, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40033, 33, 4, 1991212, 450, 400, 100, 100, 44, 36, 34, 35, 35, 100, 77, 0, 880, 1140, 2400, 7960, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40034, 34, 4, 2127897, 460, 410, 100, 100, 45, 37, 35, 36, 36, 100, 79, 0, 906, 1160, 2450, 8140, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40035, 35, 4, 2269665, 470, 420, 100, 100, 46, 38, 36, 37, 37, 100, 81, 0, 932, 1180, 2500, 8320, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40036, 36, 4, 2416556, 480, 430, 100, 100, 47, 39, 37, 38, 38, 100, 83, 0, 958, 1200, 2550, 8500, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40037, 37, 4, 2568610, 490, 440, 100, 100, 48, 40, 38, 39, 39, 100, 85, 0, 984, 1220, 2600, 8680, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40038, 38, 4, 2725867, 500, 450, 100, 100, 49, 41, 39, 40, 40, 100, 87, 0, 1010, 1240, 2650, 8860, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40039, 39, 4, 2888368, 510, 460, 100, 100, 50, 42, 40, 41, 41, 100, 89, 0, 1036, 1260, 2700, 9040, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40040, 40, 4, 3056152, 520, 470, 100, 100, 51, 43, 41, 42, 42, 100, 91, 0, 1062, 1280, 2750, 9220, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40041, 41, 4, 3229259, 530, 480, 100, 100, 52, 44, 42, 43, 43, 100, 93, 0, 1088, 1300, 2800, 9400, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40042, 42, 4, 3407730, 540, 490, 100, 100, 53, 45, 43, 44, 44, 100, 95, 0, 1114, 1320, 2850, 9580, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40043, 43, 4, 3591605, 550, 500, 100, 100, 54, 46, 44, 45, 45, 100, 97, 0, 1140, 1340, 2900, 9760, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40044, 44, 4, 3780924, 560, 510, 100, 100, 55, 47, 45, 46, 46, 100, 99, 0, 1166, 1360, 2950, 9940, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40045, 45, 4, 3975728, 570, 520, 100, 100, 56, 48, 46, 47, 47, 100, 101, 0, 1192, 1380, 3000, 10120, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40046, 46, 4, 4176055, 580, 530, 100, 100, 57, 49, 47, 48, 48, 100, 103, 0, 1218, 1400, 3050, 10300, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40047, 47, 4, 4381947, 590, 540, 100, 100, 58, 50, 48, 49, 49, 100, 105, 0, 1244, 1420, 3100, 10480, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40048, 48, 4, 4593444, 600, 550, 100, 100, 59, 51, 49, 50, 50, 100, 107, 0, 1270, 1440, 3150, 10660, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40049, 49, 4, 4810585, 610, 560, 100, 100, 60, 52, 50, 51, 51, 100, 109, 0, 1296, 1460, 3200, 10840, 0, 0, 0, 0, 0, 0, 10, 20, 2),

			new RoleUpgradeConfigData(40050, 50, 4, 5033412, 620, 570, 100, 100, 61, 53, 51, 52, 52, 100, 111, 0, 1322, 1480, 3250, 11020, 0, 0, 0, 0, 0, 0, 10, 20, 2),

		};

	}
}

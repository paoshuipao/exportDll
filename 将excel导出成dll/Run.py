#coding:utf8
import os
import sys
import xlrd
import json
import shutil
print 'platform', sys.platform
platname = sys.platform
encodeType = 'gbk'
if platname == 'darwin':
    encodeType = 'utf8'

xlsfile = u"配置表"

iconfig = '''
using System.Collections;
namespace PSPUtil 
{
	public class IConfig 
	{
		public int id;
		public int useLevel;
	}
}
'''


fileTemplate = u'''
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	%s
	public partial class GameData 
	{
		%s
	}
}
'''

classTemplate = '''
	public class %s : IConfig 
	{
		%s
		public %s(%s) 
		{
			%s
		}
		%s
	}
'''
toStringTemplate = '''
		public override string ToString()
		{
			return %s;
		}
'''

attriIntTemplate = '''
		public int %s;
'''
attriLongTemplate = '''
		public long %s;
'''

attriStrTemplate = '''
		public string %s;
'''
attriBoolTemplate = '''
		public bool %s;
'''

#argument
consTemplate = '''
			%s=%s1;
'''


dataTemplate = '''
		public static List<%s> %s = new List<%s>() 
		{
			%s
		};
'''
newTemplate = '''
			new %s(%s),
'''

allClass = []
allData = []

f = os.listdir(xlsfile)

#测试
#f = [u"G工业配置表.xlsx"]
#f = [u"Z装备基础配置表.xlsx"]
#f = [u"F副本配置表.xlsx"]

saveTableCheck = {}

#remove old code
c = os.path.join(u"配置导出", "csCode")
if platname == 'darwin':
    gbk = c.encode('utf8')
else:
    gbk = c.encode('gbk')

if os.path.exists(gbk):
	print 'gbk exist'
	shutil.rmtree(gbk)

os.mkdir(gbk)

import logging
logging.basicConfig(filename='error.log',level=logging.DEBUG)


#oldCodes = os.listdir(gbk)
#for o in oldCodes:
#	os.remove(os.path.join(c, o).encode('gbk'))

#处理每个sheet
def handleSheet(sheet):
	cl = classTemplate                      # 最终的Bean
	declare = ''                            # public int %s;
	arg = ''                                # 参数 int id1, string Name1,
	assign = ''                             # Name = Name1;
	dataClass = ''                          # bean 的名称
	dataObj = ''
	objList = ''
	toStr=''                                # toString 要写的内容
	print sheet.name
	
	nrows = sheet.nrows
	ncols = sheet.ncols
	print nrows, ncols
	if nrows == 0 or ncols == 0:
		return
		
	#Get Cell Value 
	#export 
	row_data = sheet.row_values(0)
	col_data = sheet.col_values(0)
	
	fileName = row_data[1]                  # Excel 写得那个 List       
	if fileName == "":
		print("第1行第2列的名字没有设置")
		return
	
	#补充数据  结构一致
	moreData = False
	oldData  = None
	if saveTableCheck.get(fileName) != None:
		oldData = saveTableCheck[fileName]
		objList = oldData['objList']
		moreData = True
	else:
		oldData = saveTableCheck[fileName] = {
			'objList' : '', 
		}
		

	if 'L_' in fileName:
		dataClass = fileName[2:]+"Bean"
	else:
		dataClass = fileName+"Data"	

	
	dataObj = fileName


	thirdHeng = sheet.row_values(2)          # 第3行写的注释



	keyRow = sheet.row_values(3)             # Excel 表中的第4行数据
	typeRow = sheet.row_values(4)
	outPut = []
	
	for i in xrange(2, ncols):               # 从第3行开始遍历所有类型
		if keyRow[i] != "":
			k = keyRow[i]
			# 把注释添加进 tostring
			if thirdHeng[i] !="":
				if i !=0:
					toStr += u'\"     '
				else:
					toStr += u'\"'
				toStr += thirdHeng[i]
				toStr += u'- \"+'
			else:
				toStr +=u"\"第3行缺少注释 —— \""
				
			toStr += k
			toStr += "+"

			if typeRow[i] == "Integer":
				#IConfig 接口定义的id
				if k != "id" and k != 'useLevel':
					declare += attriIntTemplate % (k)
				arg += "int %s1, " % (k)
			elif typeRow[i] == 'Long':
				declare += attriLongTemplate % (k)
				arg += "long %s1, " % (k)	
			elif typeRow[i] == "Boolean":
				declare += attriBoolTemplate % (k)
				arg += "bool %s1, " % (k)
			else:
				declare += attriStrTemplate % (k)
				arg += "string %s1, " % (k)
			assign += consTemplate % (k, k)
	arg = arg[:-2]
	toStr = toStr[:-1]                                  # 把最后的+号去除
	toStr = toStringTemplate % (toStr)
	cl = cl % (dataClass, declare, dataClass, arg, assign,toStr)
	allClass.append(cl)
	
	over = False
	allIds = set()
	for i in xrange(6, nrows):
		curRow = sheet.row_values(i)
		#print "fullRow", curRow
		line = {}
		outPut.append(line)
			
		argList = ''
		if curRow[1] == "END":
			over = True
		for j in xrange(2, ncols):
			
			key = keyRow[j]

			if key != "":
				if typeRow[j] == 'Integer' :
					try:
						line[key] = int(curRow[j])
					except:
						line[key] = 0
					if key == 'id':
						if line[key] in allIds:
							logging.debug('Error: Table Same Key '+fileName+' id= '+str(line[key]))
						allIds.add(line[key]) 
					argList += str(line[key])+", "
				elif typeRow[j] == 'Long':
					try:
						line[key] = int(curRow[j])
					except:
						line[key] = 0
					argList += str(line[key])+", "	
				elif typeRow[j] == "Boolean":
					try:
						print "curRow", curRow[j]
						
						if curRow[j] == 'true' or curRow[j] == 'TRUE' or  curRow[j] == 1:
							line[key] = True
						else:
							line[key] = False
					except:
						raise Exception("curRow", "")
						line[key] = False
						
					argList += str(line[key]).lower()+", "
				else:
					#print curRow[j]
					try:
						if type(curRow[j]) == unicode:
							line[key] = curRow[j]
						else:
							line[key] = str(curRow[j])
					except Exception as e:
						print "error", e
						line[key] = ""
					#print "line", line[key]
					argList += "\""+line[key].replace('"', '\\"')+"\", "
		
		argList = argList[:-2]
		newObj = newTemplate % (dataClass, argList)
		objList += newObj
		if over:
			break
	
	oldData['objList'] = objList
	
	dataDeclare = dataTemplate % (dataClass, dataObj, dataClass, objList)
	allData.append(dataDeclare)
	
	res = json.dumps(outPut, indent=4, separators=(', ', ': '))
	
	if fileName != "":
		c = os.path.join(u"配置导出", "client")
		outF = os.path.join(c, fileName+".json").encode(encodeType)
		print outF
		nf = open(outF, "w")
		nf.write(res)
		nf.close()
				
	if fileName != "":
		c = os.path.join(u"配置导出", "csCode")
		#gbk = c.encode('gbk')
		#shutil.rmtree(gbk)
		#os.listdir(gbk)

		#os.mkdirs(gbk)

		outF = os.path.join(c, fileName+".cs").encode(encodeType)
		print outF
		nf = open(outF, "w")
		outCon = fileTemplate % (cl, dataDeclare)
		nf.write('\xef\xbb\xbf'+outCon.encode('utf8'))
		nf.close()
		

def main():		
	for i in f:
		print "Read File", i
		if i.find(".xls") == -1 or i.find('$') != -1 or i.find('#') != -1:
			continue
			
		name = os.path.join(xlsfile, i)
		book = xlrd.open_workbook(name)
		sheet_names = book.sheet_names()
		for n in sheet_names:
			sheet = book.sheet_by_name(n)
			handleSheet(sheet)
	
	
main()		
	
print "generate CharAttribute"
path = u'提供'
os.chdir(path)
#cmd = os.path.join(path, "handleProperty.py").encode('gbk')
cmd = "python %s" % ("handleProperty.py")
print cmd
os.system(cmd)	 
os.chdir('..')

peizhiDir = u'配置导出'

dirname = u'配置导出/csCode'
dn = dirname.encode(encodeType)


os.chdir(peizhiDir)
os.system('copy configDll.csproj csCode')
os.system('copy AssemblyInfo.cs csCode')
os.system('copy UpdateSln.py csCode')
os.system('copy IConfig.cs csCode')

os.chdir('csCode')

dllCmd = 'python UpdateSln.py'
os.system(dllCmd)
buildCmd = 'xbuild new.csproj'
os.system(buildCmd)

os.chdir('../..')

	
print '开始复制到U3D 目录'
U3D = '/Users/liyong/Desktop/allUnity/Assets/Plugins/'
print U3D
os.system('copy 配置导出/csCode/obj/Debug/configDll.dll %s ' % (U3D))
	
	
	

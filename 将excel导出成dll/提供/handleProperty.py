#coding:utf8
import os
import sys
import re
import json
encodeType = 'gbk'
if sys.platform == 'darwin':
    encodeType = 'utf8'

'''
{
"KEY" : {"id":123,  "comment":"what"}
}
'''

checkSameID  = {}

pat = re.compile("(/\*\*(.*)\*/\n)?\s*int (\w+)\s*=\s*(\d+)\s*;")

con = open(u"属性KEY.txt", "r").read()
mat = pat.findall(con)
jout = {}
enumKv = ""
keyToCN = ""

for i in mat:
	print i[1]
	print i
	com = i[1].decode('gbk')
	byt = com.encode('utf8')
	print type(byt)
	jout[i[2]] = {"id":int(i[3]), "comment":byt}
	idd = int(i[3])
	if checkSameID.get(idd) !=  None:
		raise Exception("idd same "+str(idd)+" "+i[2],  "")
	checkSameID[idd] = i[2]
	enumKv += "\t\t\t"+i[2]+"= %d"%(int(i[3]))+", //%s\n" % (byt)	
	keyToCN += "\t\t\t{CharAttributeEnum."+i[2]+", \""+byt+"\"},\n"
	
f = open("attribute.json", "w")
f.write(json.dumps(jout, ensure_ascii=False))
f.close()

temp = '''
using System;
using System.Collections;
using System.Collections.Generic;
namespace ChuMeng {
	public class CharAttribute {
		public enum CharAttributeEnum { 
%s
		}
		
		public static Dictionary<CharAttributeEnum, string> keyToCN = new Dictionary<CharAttributeEnum, string>() {
%s		
		};
	}
	
}
'''

kv = '\xef\xbb\xbf'+temp % (enumKv, keyToCN)
path = u'配置导出'
realPath = os.path.join(os.path.join('..', path), 'csCode').encode(encodeType)

f = open(os.path.join(realPath, "CharAttribute.cs"), 'w')
f.write(kv)
f.close()

		

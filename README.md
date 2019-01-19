# C sharp
#### 项目介绍
传智播客：C#教程

1. 使用 Readme\_XXX.md 来支持不同的语言，例如 Readme\_en.md, Readme\_zh.md

记得将git的邮箱改成和码云或者github的账户邮箱一致的时候，push代码才算在贡献中！

2018.12.8
	开始新建分支，以后每一章节新建一个分支
2018.12.14	
	创建本地分支并切换	git checkout -b 07_FlightChess
	推送到远程分支		git push origin 07_FlightChess
2019.1.13
1、值传递和引用类型传递
	string s1 = "张三";
	string s2 = s1;
	s2 = "李四";
	Console.WriteLine(s1);//张三
	Console.WriteLine(s2);//李四
	//string比较特殊，具有不可变性，每次重新赋值都会开辟新的空间
	//具体分析(自己分析，加深理解)
	&s1
	0x00efeea8//栈地址
	*&s1: 0x030023c4//堆地址
	&s2
	0x00efeea4//栈地址
	*&s2: 0x030023c4//堆地址
	string s2=s1的时候，他们指向同一个堆空间。
	但是s2="李四"的时候,
	&s2
	0x00efeea4//栈地址
	*&s2: 0x030023d8//堆地址
	它新开辟了一个堆空间写入"李四"，并且让s2指向新的对空间
	所以s1的值没变还是张三
	s2的值变了，变成一个新的李四
	
	
2、'protected'和'protected internal'有什么区别？ ❓  #问题
	protected表示“仅此类和派生类”。
	internal意味着“只有这个程序集中的类”。
	protected internal表示“ protected OR internal ”（同一程序集中的任何类，或任何派生类 - 即使它位于不同的程序集中）。
	即它并不意味着“保护和内部”（同一个组件内只有派生类）。
	
	
2019.1.16
git删除文件夹
	命令：
	git rm -rf 文件夹名
	此时git中的文件夹已经删除，但是有时候还需要手动删除一遍，因为例如vs里面的bin文件夹和debug文件夹一般是被.gitignore文件忽略的，所以删除自然也不会删除，需要手动将剩下的文件夹删除
	
2019.1.17
	MD5加密。。。学习可以先用MD5加密学习一下。如果不是为了适应旧程序，就用新的SHA1加密吧。
	
2019.1.19
让数字在给定的范围内循环
	比如想用一行代码让一个值到了10就变回0.
	int i=0;
	int length=10;
	i=(i+1)%length;//这样一旦超过length余数就是0。可以从头开始加
	
	
	
	
	
	
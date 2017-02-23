MSSQL Connection Library

How can you use it?

Actually that's so basic, and it's my first post on GitHub.
Firstly, you must add DLL in your C# project then add "using mssqlCon;" 

Library requires two string variables from you. First one is connection string and the other one is SQL query string. 

Example Code,

using mssqlCon;

string adres,text;

adres="Server=server_ip;Database=db_adı;user id=user_id;password=pw";
text = "SQL Query.";

mssqlBaglanti ms = new mssqlBaglanti(); 
string donus = ms.mssqlBaglan(adres, text); 

Trek Bikes – Weekend Programming Exercise

Introduction 

This small exercise will be used as part of the hiring evaluation of the Ascend RMS development team. 

You can complete it on your own schedule, using mostly techniques and tooling of your choice. There are 

some suggestions below, but feel free to go beyond these. You’re welcome to use whatever online 

resources you wish (StackOverflow, MSDN, etc), but we ask that you complete it by yourself. 

The Technical Setup 

There presently exists an ASP.NET SignalR persistent connection endpoint at 

https://sensorsource.azurewebsites.net/sensor/readings that is broadcasting sensor 

readings on various intervals for five sensors. The JSON of each broadcast event looks like: 

{ 

 "SensorId": [Sensor Number 1 – 5], 

 "Value": [Decimal Value .6 - .9] 

} 

There is no authentication necessary to reach this SignalR endpoint. Each sensor will broadcast a new 

value every four to ten seconds. 

There also exists a SQL (Azure) Database that contains some information about each sensor. 

Server: hrr4eyxqec.database.windows.net

SQL Server login: SensorReader

SQL Server password: P}Sd8df&sdf5{sdf0f|>

Database name: SensorSource

Table of interest: Sensors

There are no source IP restrictions on this database.

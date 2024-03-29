﻿Name: Anastasia Gonzalez and Aaron Bellis
UID: u0985898 & u0981638
Last Update: 12/13/17

SpaceWars Client - PS7 
Created for CS 3500 2017 Fall Semester

Initial Design Ideas: The GUI will need three panels. One panel is the top bar which will be a tableLayoutPanel and  
the side and center panel will be custom. The side panel will contian the scoreboard and the center one will be the 
game. The size of the form will resize when the server send the proper information. 

What works: We were able to get everything to work. We did a lot of troubleshooting and debugging to get everything 
working. The hardest part to get correct was the GUI. We struggled with updating the information to the GUI correctly 
without causing problems or errors. 

What didn't work: We really struggled with getting the scoreboard to work properly since the health points would 
not update. We did a lot of debugging to get it to work. We also had problems with the black color player not filling 
in the scoreboard color in everytime. 

Notes for the TAs: Our project was setup in an the proper MVC format. We used the proper abstraction so that the 
different classes could speak to each other and work together to create a fuctional spreadsheet GUI. 

Added Features: Our scoreboard is color coordinated and our GUI has a fun Santa Claus theme. We picked a white 
background to represent the snow. 

How to Run: Start the server. Once the server is ready, press start on the client code. Enter in a name and press connect.


SpaceWars Server - PS8
Created for CS 3500 2017 Fall Semester

Initial Design Ideas: Our initial ideas for the server are to have an added feature that is called King of the Hill (more
details below). Our XML reader also allows for all the settings to be changed... starting hit points, projectile speed,
engine strength, turning rate, ship size, star size, universe size, time per frame, projectile firing delay, and respawn 
delay.

What works: We were able to get everything to work. The networking and the updating of the world all works properly. We 
also handled all the exceptions that we encountered while testing. The hardest part was properly making the extra feature 
(King of the Hill) to work correclty. We had most of the logic correct except properly setting the king at the correct 
time. 

What we struggled with: We really struggled with getting the ships and projectiles to be represented as dead at the
proper moment. At the beginning we would remove them from the world before we sent the dead representation to the clients. 
After re-evalutating the process we decided to set then as dead then send the info to the clients. At the end we would
go through all the ships and projectiles and remove the dead ones from the world. We also had a hard time speeding up the 
server while handling 10+ clients so we made some methods asynchronous so that now we can handle up 30 clients without
any problems. 

Areas to improve in: We would imporve the code by having two severs. One that would run when the added feature (King of 
the Hill) setting was on and the other would run when it was just the normal space wars game. 

Notes for the TAs: Our project was setup in an the proper MVC format. We used the proper abstraction so that the 
different classes could speak to each other and work together to create a fuctional server. We were given an extension 
by Dr. Kopta to turn in our assignment on Sunday.

Added Feature: Our special feature is the King of the Hill. 
To use in the XML: <KingOfTheHill>true</KingOfTheHill>
The rules are as follows:
1) The king is the first player who enters the world
2) The king gets 3 extra hit points
3) The other players can only fire projectiles to hurt the king
4) The king can fire at anyone
5) When the king is dead a new ship is named king randomly

Testing: We focused most of our testing effort on the world. This is were all the code and updating is happening so we 
wanted to make sure that is was very clear and correct. We got nearly 100% code coverage here. We also tested the ship, 
projectile, and star classes until they also had 100% code coverage. In addition, we tested part of the network 
controller when possible.

How to Run: Press the play button (make sure that the server solution is set as the StartUp project). Once the server is
ready, wait for a client to connect. 

SpaceWars Server - PS9

For the implementation of the web server, we made a new project that dealt only with the web browser portion of the code. 
Once a connection is made we read the first line of text and decide which table to present to the user. If the connection 
is fault or the information passed in is incorrect then we report back a web page that has information on the problems that occurred. 
The hardest part that we were unable to get working was getting the first line of text to read properly. 

Part 1 Complete

Part 2 Basic stats showing, everything else not showing

Database Structure:

// Relates games to           // relates games to game stats 
// players
+-------------------+         +---------------------------------+
|  PlayersInGame    |         |           GameStats             |
+----------+--------+         +--------+----------+-------------+
| playerID | gameID |         | gameID | duration |   gameMode  |
+----------+--------+	      +--------+----------+-------------+
|   int    |  int   |         |   int  |   time   |   varChar   |
|    NN    |  NN    |         |   NN   |    NN    |     NN      |
|  unique  |        |         | unique |          |             |
+----------+--------+         |   AI   |          |             |
                     	      +--------+----------+-------------+

// relates players to player stats
+------------------------------------------+
|               PlayerStats                |
+----------+------------+-------+----------+
| playerID | playerName | score | accuracy |
+----------+------------+-------+----------+
|   int    |  varChar   |  int  |  double  |
|    NN    |    NN      |  NN   |    NN    |
|  unique  |            |       |          |
|    AI    |            |       |          |
+----------+------------+-------+----------+





	
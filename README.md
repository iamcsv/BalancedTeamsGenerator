###**Project's Title: Balanced Teams Generator**

#### Video Demo:  <https://drive.google.com/file/d/16U8KTCDrh275tOEgWEVhI75bT_kzE-yp/view?usp=share_link>

##**Project Description**

The BTG allows user to generate squads of teams using entered (or taken from SQL DB (in future)) Player names and rating. 

The application is written in C#. I'd used Visual Studio 2022 (Windows Forms), MAMP (to create MySQL server), PHP lite admin to manage SQL DB, Notepad ++ for Readme.md.
 
I'd choose Windows Forms because this framework allows you to create a visually comfortable shell with functions relatively quickly. 
Especially when you work at full-time job and have only 7 days to create the project. :)

In the future, BTG will allow user to save and load players names and ratings in DB. But I need to untie the program from having to run a MySQL server.
Also, I'll add more algorithms to generate teams. Some really random (but rating based) cases. 
To implement that, I need to code much more and have a source of data (like local/net DB) to randomize.  


##**How to Install and Run the Project**

At this stage, user needs Microsoft Visual Studio 2022 and MAMP (or other apps to start MySQL server) to run the application 


##**How to Use the Project**

At Login Page, user is able to Log in or change page to Registration. Registration and logging will allow in the future to save and load players and their rating into personal DB. 
BTG today allows Login and Registration (working clearly, save data to MySQL DB). Save/Load function is absent in this early version. 

At the Main Page, user is able to enter 1-14 (nick)names of players and, if needs, their rating. 
Balance Teams button will create 2 teams, where the total rating of all players will be almost the same.  
Shuffle button will create 2 random teams, regardless of player rating.

At "Your teams" window user is able to copy created teams list and use it (to send to another people/players). 
Perhaps once, even directly from application to phone messengers. 

##**Include Credits**

This project is possible because of:
**edX** free Harvard course "CS50x"
**SoftServe** training and mentoring program 
**EPAM** "C# for QA" training course

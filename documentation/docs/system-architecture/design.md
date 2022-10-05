---
sidebar_position: 1
---

# Database Table
![Database Table](/img/ERD.png)

Sokrobans reliance on a database is very minimal, though crucial. The DB will only need to store the players Username(varchar,NOT NUll), Password(varchar,NOT NULL), HighScore(int), best time(time), and level(int).UserName and Password are the only two fields in the DB that are marked as NOT NULL, due to the simple fact that a user must have an account in order to "save" any data. One table is all that will need to be created in order to store the inforamtion and be utilized to pass data back and forth between the API.


# API Diagram
![API Diagram](/img/API.png)


Sokroban will utilize an RESTful API hosted via Azure to pass player data back and forth between the game and the database. A player's high score, best time and level will all be saved.The best time, high score, and level will be updated after every "run" the game will check with the DB to see if any of the fields have been topped and replace update the data in the table. There will also be a leaderboard that will display the table in the database (minus the user password of course) filtered by top score overall.



A description the different components and their interfaces. For example: client, server, database.

For each component provide class diagrams showing the classes to be developed (or used) and their relationship.

Sequence diagrams showing the data flow for _all_ use cases. One sequence diagram corresponds to one use case and different use cases should have different corresponding sequence diagrams.

Describe algorithms employed in your project, e.g. neural network paradigm, training and training data set, etc.

If there is a database:

Entity-relation diagram.

Table design.

A check list for architecture design is attached here [architecture\_design\_checklist.pdf](https://templeu.instructure.com/courses/106563/files/16928870/download?wrap=1 "architecture_design_checklist.pdf")  and should be used as a guidance.




# UML Diagram

![UML Diagram](/img/UML_Diagram.png)

# Sequence Diagrams 


- Use Case 1 Sequence Diagram

    ![Figure](/img/Sequence1.png)


- Use Case 2 Sequence Diagram

    ![Figure2](/img/Sequence2.png)


- Use Case 3 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence3.png)


- Use Case 4 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence4.png)


- Use Case 5 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence5.png)


- Use Case 6 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence6.png)


- Use Case 7 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence7.png)

- Use Case 8 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence8.png)


- Use Case 9 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence9.png)


- Use Case 10 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence10.png)


- Use Case 11 Sequence Diagram

    ![Use Case 1 Sequence Diagram](/img/Sequence11.png)




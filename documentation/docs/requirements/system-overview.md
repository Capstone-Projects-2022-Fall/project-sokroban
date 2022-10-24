---
sidebar_position: 1
---

# System Overview

- Project Abstract<br/>
    "SOKROBAN" is a puzzle game that will task users to move a various amount of crates across procedurly generated maps in order to complete increasingly difficuly levels . In order to complete each level the user will need to move each crate to one of the designated location tiles. SOKROBAN will include a single player story mode as well as head to head multiplayer mode where users can compete with friends to see how far and how quickly they can complete SOKROBANS challeneging levels.

- Conceptual Design<br/>
    “SOKROBAN” will be built with Unity and utilize multiple tools in order to function 
    
    - IDE: Visual Studio
    - A restful API will be created to get/set user account information,highscores,and level completion time
            - Will be coded in C# and utilize microsofts .Net Framework  
    - Unity's Photon Networking framework will handle the networking functionality and host the online server.
    - Azure will be used to host the database and API 
    - SQL managment studio 

- Background <br/>
    “SOKROBAN” will be an updated version, of the original game called “Sokoban” which was originally published in December 1982. There are also a lot of different projects built by different users online that identically copy the game, however, from my research, none of them offers a multiplayer option or a harder version of the game such as “SOKROBAN” will do. Finally, the game will be built from scratch without using any open-source product or any other existing source code. 

    - Sources: https://github.com/topics/sokoban-game

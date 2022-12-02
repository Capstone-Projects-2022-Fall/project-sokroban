![Open in Codespaces](https://classroom.github.com/assets/open-in-codespaces-abfff4d4e15f9e1bd8274d9a39a0befe03a0632bb0f153d0ec72ff541cedbe34.svg)
<div align="center">

# Project Name: SOKROBAN 2D Game
[![Report Issue on Jira](https://img.shields.io/badge/Report%20Issues-Jira-0052CC?style=flat&logo=jira-software)](https://temple-cis-projects-in-cs.atlassian.net/jira/software/c/projects/DT/issues)
[![Deploy Docs](https://github.com/ApplebaumIan/tu-cis-4398-docs-template/actions/workflows/deploy.yml/badge.svg)](https://github.com/ApplebaumIan/tu-cis-4398-docs-template/actions/workflows/deploy.yml)
[![Documentation Website Link](https://img.shields.io/badge/-Documentation%20Website-brightgreen)](https://applebaumian.github.io/tu-cis-4398-docs-template/)


</div>


## Keywords

Section 704, C#, Unity, 2D game, Desktop application, Multiplayer

## Project Abstract

“SOKROBAN” is a game that will allow the user to solve challenging puzzles by pushing crates and placing them into a specific place inside a room when selecting the “Single Player” mode or challenge friends and people online when selecting the “Multiplayer” mode.

## High Level Requirement

The user will be able to download this game on his desktop and play. Upon launching the application and successfully logging in, a welcome screen will appear with different options such “Single Player Mode”, “Multiplayer”, “High Scores” and “Exit”. The “Single Player Mode” option will ask the user of the difficulty they want to play on. There will be a “normal” and a “hard” mode.  The “Multiplayer” will allow the user to invite one of his/her friends and challenge them into different levels while sharing the same screen or find another player online. Finally, the “High Scores” tab will be for the user to see the high scores and the “Exit” option will allow the user to exit the game.

## Conceptual Design

“SOKROBAN” will be done in Unity editor using C# coding language. The database will be built using SQL, and the Multiplayer will be created by using the Photon Engine. 

## Background

“SOKROBAN” will be an updated version, with added features, of the original game called “Sokoban” which was originally published in December 1982. There are also a lot of different projects built by different users online that identically copy the game, however, from my research, none of them offers a multiplayer option or a harder version of the game such as “SOKROBAN” will do. Finally, the game will be built from scratch without using any open-source product or any other existing source code. 

Sources: https://github.com/topics/sokoban-game


## Required Resources

Operating System: Any operating system that can successfully run the Unity Editor. However, Windows OS is preferred. 

Software: 
 - Visual Studio 2022: This IDE is required in order to utilize Unity and the .Net Framework
 - Installation of Unity Editor is required, this is where we will create the game and all its components
 - AWS will be utilized in hosting our API and database
 - SQL managment studio for creating the games database
 - Photon: Unity's Networking Framework for multiplayer functionality 
 - GitHub Desktop is preferred for easier interaction with GitHub, which will be utlized for documentation and version control.


## Collaborators

[//]: # ( readme: collaborators -start )
<table>
<tr>
    <td align="center">
        <a href="https://github.com/Gaben1025">
            <br />
            <sub><b>Arthur Kozhevnik</b></sub>
        </a>
    </td>
    <td align="center">
        <a href="https://github.com/robnano">
            <br />
            <sub><b>Roberto Nano</b></sub>
        </a>
    </td>
    </td>
    <td align="center">
        <a href="https://github.com/F-Rabinovich">
            <br />
            <sub><b>Felix Rabinovich</b></sub>
        </a>
    </td>
    </td>
    <td align="center">
        <a href="https://github.com/Tun92789">
            <br />
            <sub><b>Riddhi Patel</b></sub>
        </a>
    </td></tr>
</table>

[//]: # ( readme: collaborators -end )

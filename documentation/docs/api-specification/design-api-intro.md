---
sidebar_position: 1
description: What should be in this section.
---

Design Document - Part II API
=============================

1. MainMenuOperator </br> 
    Class Purpose: The MainMenuOperator will handle all the navigational code for Sokroban. This method will allow the users to traverse between the leaderboad, Single Player, and Multiplayer aspects of the game. 

    Method:
        - SinglePlayer():void
            - Takes the user to single player version of the game
            - No Pre-Conditoins
            - Parameters: None
            - Return Values: None
        - Multiplayer():void
            - Takes the user to the Multiplayer version of the game
            - No Pre-Conditions
            - Parameters: None
            - Return Values: None
        - LeaderBoard():void
            - Takes the user to the leaderboards
            - Pre-Condtions: To see own stats user must be logged in
            - Parameters: None
            - Return Values: None
        - LogOut():void
            - Returns the user to the login screen.
            - No Pre-Conditions
            - Parameters: None
            - Return Values: None
    
2. AccountHandler  </br> 
    Class Purpose: The account Handler Class will send the users login data to the API, which will then be checked with the current data in the DB. If correct the user will be loged in, if incorrect the user will be notified that the information entered was wrong, and theyll need to re enter the data or continue as guest.
    
    Data Fields: 
    - Username
        - Type: string
    - Password
        - Type: string


    Method:
        - OnClickLogIn(username,password):void
            - Communicates with the API to log a user into the game and recover their information
            - Pre-Condition: User must have an account
            - Parameters: Username, Password
            - Return Values: None
        - OnClickSignUp():void
            - Directs user to a create account screen 
            - No Pre-Conditions
            - No Parameters
            - Return Values: None

3. LeaderBoard  </br> 
    Class Purpose: The leaderBoard Class, will call on the API to pull a list of users and their stats and present it, so that users can see where they stand amongst their peers. This Class will have two data pulls, at the top of the screen will be the users score and below it will be the actuall leaderboard. this will require the api to pull specific data on just the user as well as a complete filtered pull of the DB.

    Data Fields: 
    - Username
        - Type: string
    - Password
        - Type: string
    - Database table data
        - Type: List

    Method:
        - GetInfo(username,password,DB list):void
            - populates leaderboard with data
            - Pre-Conditions: If user wishes to see their own stats they must have an account
            - Parameters: username,password,Database list
            - Returns:None

4. ConnectionToServer  </br> 
    Class Purpose:  The purpose of this class is to communicate with our Photon multiplayer server and elstablish an online connection so when the player is ready they may play online with their peers.

    Data Fields: 
    - ConnectedToServer 
        - Type: Boolean
   

        Method:
         - OnConnectedToMaster():void
            - Connects user to server
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - OnJoinedLobby():void
            - Throws a user into lobby
            - Pre-Conditions: None
            - Parameters: None
            - Returns: None
        - OnDisconnected(DisconnectedCause):void
            - Disconnects user from online services 
            - Pre-Conditions: None
            - Parameters: None
            - Returns: None

5. CreateAndJoinRoom  </br> 
    Class Purpose: This class holds the code that will allow a player to either host their own game and allow other to join on them, or to hop into a game hosted by another.

    Data Fields: 
    - CreateInpur
        - Type: InputField
    - JoinInput
        - Type: InputField
    - ErrorText
        - Type: Text


    Methods:
        - CreateRoom():void
            - Allows user to create a room 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - JoinRoom():void
            - Allows user to join a room
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - OnJoinedRoom():void
            - Handles a user joining a room
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - OnCreatedRoomFailed(Short,string):void
            - Handles error if user fails to create a room
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - OnJoinRoomFailed(short,string):void
            - Handles error if user fails to enter a room
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - LeaveRoom():void
            - Allows a user to leave a room
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - OnLeftRoom():void
            - Handles error if a user left your room
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

6. Transform  </br> 
    Class Purpose: Handles positioning of the player 

    Data Fields: 
    - Position
        - Type: Vector3
    - Rotation
        - Type: Vector3
    - Scale
        - Type: Vector3

    Methods: None

7. SpriteRenderer  </br> 
    Class Purpose: Renders the players Sprite (character icon)

    Data Fields: 
     - Sprite   
          - Type: Sprite3

    Methods: None

8. RigidBody2D  </br> 
    Class Purpose: Handles Hit box of player, this "box" is the actual object that interacts with the boxes
    
    Data Fields: 
     - mass  
          - Type: Float

    Method:None

9. BoxCollider2D  </br> 
    Class Purpose: Handels Hit box of Boxes, this "box" is the actual object that interacts with the boxes

    Data Fields: 
     - Offset   
          - Type: Vector3
    - Size   
          - Type: Vector3
  
    Method:None

10. BoxController  </br> 
    Class Purpose: Handels all logic of the boxes location,movement, whether theyre on the right spot, etc.

    Method:
        - Update():Void
            - Updates box postion and status
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - OnEnterCollosion():void
            - Handles how the box reacts to user interaction 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
          

11. Animator  </br> 
    Class Purpose: Handles Animation for single player
    
    Methods:
        - Controller():
            - Purpose: Holds code that will communicate with other methods in order to animate base game.
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

12. PhotonAnimatorview  </br> 
    class Purpose: Handles Animation for multiplayer
    
    Methods: 
        - SynchronizeWeights():bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - SynchronizeParameters():bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

13. PhotonTransformViewClassic  </br> 
    class Purpose: Handels the positioning of both players sprites, so that each can be displayed on the level.

    Methods:
        - SynchronizePosition():bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - SynchronizeRotation():bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - SynchronizeScale():bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

14. PhotonView  </br> 
    Class Purpose: Shows each players ID and who's hosting the game. all displayed on the backend

    Methods:
        - Id():
            - Holds player ID
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        -OwenerShip():
            - Shows whos hosting the game
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

15. LevelGenerator  </br> 
    Class Purpose: Procedurly generates each level of Sokroban.

    Methods: Unknow (come back to me on monday)








 


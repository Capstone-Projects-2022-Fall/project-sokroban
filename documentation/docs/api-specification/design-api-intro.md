---
sidebar_position: 1
description: What should be in this section.
---

Design Document - Sokroban Unity Game API
=============================

 ## HomeScreenManager
    Class Purpose:The HomeScreenManager will navigational code for create account adding with username and password. This method will allow the user to login existing account, signup and as a guest option for playing this game.

    Data Fields:
    - usernameInput: 
        - Type: InputField
    - passwordInput: 
        - Type: InputField
    - errorText: 
        - Type: Text      

    Method:
        - OnClickLogin(): void 
            - Takes the user to login into existing account
            - No Pre-Conditoins
            - Parameters: Nonne 
            - Return Values: None
        - OnClickSignUP(): void                 
            - Takes the user to Sign up into new account
            - No Pre-Conditoins
            - Parameters: Nonne 
            - Return Values: None
        - OnClickLogin(): void 
            - Takes the user to play as a guest account
            - No Pre-Conditoins 
            - Parameters: None 
            - Return Values: None

## MainMenuManager 
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

## ConnectiontoServer
    Class Purpose: The purpose of this class is to communicate with our Photon multiplayer server and elstablish an online connection so when the player is ready they may play online with their peers.

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

## AccountHandler  
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

## SPLobbyManager
    Class Purpose: This SPLobby class will hold the code to play a single-player game. This method will allow entering the box amount, the player can select normal mode and challenge mode to play the game. 

    Data Fields:
    - numBoxes: 
        - Type: InputField
    - errorText: 
        - Type: Text

    Method: 
        - nextSandboxModebtnClick(): void 
            - Allow user to enter box number to play
            - No pre-conditions 
            - No parameters
            - Return value: none 
        - nextNormalModeBtnClick(): void 
            - Allow user to select normal mode to play
            - No pre-conditions 
            - No parameters
            - Return value: none 
        - nextChallengeModeBtnClick(): void 
            - Allow user to select challenge mode to play 
            - No pre-conditons
            - No parameters
            - Return value: none
        - OnSubmitClick(): void 
            - Allow to user to submit button to play 
            - No pre-conditions
            - No parameters
            - Return value: none

## ReturnButton
    Class Purpose:This class will hold the code that would allow the player to return to the homescreen. 
 
    Method:
        -OnReturnClick(): void 
            - Allow user to return to home screen. 
            - No pre-conditions
            - No parameters 
            - Return value: none 

## CreateAndJoinRoom  
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

## Level generator: 
    Class purpose: This class Level generator will handles map, level size, prefab, crates, singleplayer mode and multiplayer mode, This method will generated finishedmap, level size,and resetmap in the game.

    Data Fields:
    - Map
        - Type: cell
    - levelSize
        - Type: int
    - groundPrefab
        - Type: GameObject
    - wallPrefab
        - Type: GameObject
    - cratePrefab
        - Type: GameObject
    - targetPrefab
        - Type: GameObject
    - playerPrefab
        - Type: GameObject
    - Size
        - Type: int
    - crates
        - Type: int
    - isSandbox
        - Type: bool
    - isNormal
        - Type: bool
    - isChallenge
        - Type: bool
    - isCoop
        - Type: bool
    - isVS	
        - Type: bool

    Method: 
        - Awake(): void
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Start(): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - setTier(): void 
            - This method set the tier. 
            - Pre-Conditoins: None 
            -  Parameters: None
            - Returns: None
        - setFinishedMap(): void 
            - This method will finished the map. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - getLevelsize(): void 
            - This method will get level size.
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - translateToPrefabs(int): void 
            - This method will translate ot prefabs. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - exportMap(Level): void 
            - This method will allow to export level.
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - resetMap(): void 
            - This method will allow to reset map.  
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## Level
    Class Purpose: This class will handles Level with size(height,width), players, random generating level. This method will allow to generate the level, spawn crates for single player, and multiplayer. 

    Data Fields: 
    - flowCell	
        - Type: int 
    - Width
        - Type: int
    - Height
        - Type: int
    - Players
        - Type: int 
    - Map
        - Type: cell
    - Rand
        - Type: Random

    Method: 
        - generate(): void
            - Pre-Conditoins: None 
            - Parameters: None
            -  Returns: None
        - spawnCratesMP(int): bool
            - Pre-Conditoins: None 
            -  Parameters: None
            - Returns: None
        - spawnCratesSP(int): bool 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - spawnPlayer(int): bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - spawnGoals(int): bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - removeNull(): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - removeWalls(int, int, int): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - postProcess(): void  
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - CleanAloneWall(): void
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - CleanUselessRoom(): bool
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - CelltoWall(cell): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - floodFill(cell,cell,int,int): int
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - cleanDeadCell(): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - placementAllowed(Template,int,int): bool 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - placementTemplate(Template,int,int): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - hasErrors(): bool  
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - ToString: string 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - getMap(): cell  
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## ChangeSound
    Class Purpose: This sound class will hold the code for turn on sound during the play, and also will allow player to mute click. 

    Data Fields:
    - soundOnImage
        - Type: Sprite 
    - soundOffImage
        - Type: Sprite 
    - button
        - Type: Button 
    - isOn
        - Type: bool
    - audioSource
        - Type: AudioSource

    Method:
        - Start(): void 
            - Allow user ot start sound while playing the game 
            -  Pre-Conditoins: None 
            - Parameters: None
            -  Returns: None
        - onMuteClick(): void 
            - Allow user to mute sound while playing the game 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## ScoreSystem
    Class Purpose: This ScoreSystem class will hold the code for scoring included points, moves and current score. This method will entering number of move boxes, and update score. 

    Data Fields: 
    - totalScore
        - Type: float 
    - CurrentScore
        - Type: float 
    - pointsText:
        - Type: Text 
    - movesTaken: 
        - Type: int 
    
    Method:
        - UpdateScore():  void 
            - This method will update score while playing 
            -  Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Update(): void 
            - This method will update scoring 
            - Pre-Conditoins: None 
            -  Parameters: None
            -  Returns: None


## LevelCount
    Class purpose: This class LevelCount will hold the code for counting level while playing, this method will update complete level in screen while playing the game. 

    Data Fields:
    - levelText: 
        - Type: Text 

    Method: 
        - Update(): void 
            - This method will update the completed level on the screen. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## Timercount
     Class purpose: This class TimerCount will hold teh code for time, how much time take to win level while playing. This method will update timer in screen while playing the game 

    Data Fields:
    - timerText: 
        - Type: Text 
    - Timer: 
        - Type: float
    - LevelWon:
        - Type: bool

    Method: 
        - Update(): void 
            - This method will update the time on the screen. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None



## LeaderBoard  
    Class Purpose: The leaderBoard Class, will call on the API to pull a list of users and their stats and present it, so that users can see where they stand amongst their peers. This Class will have two data pulls, at the top of the screen will be the users score and below it will be the actuall leaderboard. this will require the api to pull specific data on just the user as well as a complete filtered pull of the DB.

    Data Fields: 
    - recordContainer
        - Type: Transform
    - recordTemplate
        - Type: Transform 

    Method:
        - Start()):void
            - populates leaderboard with data
            - Pre-Conditions: If user wishes to see their own stats they must have an account
            - Parameters: username,password,Database list
            - Returns:None

## GameManager: 
    Class Purpose:This class will handles level counter, next level, undo button, reset button, and won the game, this method will allow the user to start, update the game, and also allow to going to next level and check win into the leaderboard.
    
    Data Fields:
    - nextLevelBtn
        - Type: Button
    - undoBtn
        - Type: Button
    - resetBtn
        - Type: Button
    - loadingText
        - Type: Text
    - counter
        - Type: int
    - wonText
        - Type: Text
    - boxesOnTarget
        - Type: bool
    - levelCounter	
        - Type: int 
    
    Method:
        - Awake(): void
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Start(): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Update(): void 
            - This method update the screen. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - nextLevelBtnClick(): void 
            - This method will allow to go into next level. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - checkWin(): void 
            - This method will allow player to check win in leaderboard tab.  
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## Template 
    Class Purpose: This class will handles random rotation and clockwise rotation.

    Data Fields:
    - Template
        - Type: 2D Array
    - GetCell(int, int)
        - Type: Cell
    
    Method:
        - rotate(): void 
            - This method will add rotation. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - randomRotation(): void
            - This method will add random Rotation while playing. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - clockwiseRotation(int): void 
            - This method will add clockwise Rotation while playing. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## Templates
     Class Purpose: This class will handles template 1 to 19, random templates. 

    Data fields:
    - Templates1-19
        -  Type: cell [][]
    -  List<Cell[][]>: 
        - Type: templates

    Methods: 
        - getRandom(): Template
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## CameraController 
    Class purpose: This class will handles mapsize and modsize. 
    
    Data Fields
    - Cam
        - Type: Camera
    - mapSize
        - Type: float
    - xMod
        - Type: float
    - yMod
        - Type: float
    - sizeMod
        - Type: float

    Method: 
        - Start(): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Update(): void
            - This method will update the map size and mod size. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## Transform  
    Class Purpose: Handles positioning of the player 

    Data Fields: 
    - Position
        - Type: Vector3
    - Rotation
        - Type: Vector3
    - Scale
        - Type: Vector3

    Methods: None

## SpriteRenderer   
    Class Purpose: Renders the players Sprite (character icon)

    Data Fields: 
     - Sprite   
          - Type: Sprite3

    Methods: None

## Box
     Class Purpose: This class will hold the code for the box, This method will update the move to box, target position for the box, and boxblocked while playing the game. 

    Data Fields: 
    - Arrived
        - Type: bool
    - Move(Vector2):
        - Type: bool
    - BoxBlocked(Vector3, Vector3):
        - Type: bool
    
    Method: 
        - Update(): void 
            - This method will update the Box on the screen. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - onTargetPosition(): void 
            - This method will update box on target position. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None


## RigidBody2D  
    Class Purpose: Handles Hit box of player, this "box" is the actual object that interacts with the boxes
    
    Data Fields: 
     - mass  
        - Type: Float

    Method:None

## BoxCollider2D  
    Class Purpose: Handels Hit box of Boxes, this "box" is the actual object that interacts with the boxes

    Data Fields: 
     - Offset   
        - Type: Vector3
    - Size   
        - Type: Vector3
  
    Method:None

## Player 
    Class Purpose: This class will handles player for single player and multiplayer.
    
    Data fields:
    - Moves: 
        - Type: struct 
    - BlockedBy: 
        - Type: struct
    - m_readyForInput
        - Type: bool
    - Move(Vector2)
        - Type: bool
    - Blocked(Vector3, Vector3)
        - Type: BlockedBy 
    
    Method:
        - Start(): void 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Update(): void 
            - This method will update into the screen. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - onTargetPosition(): void 
            - This method will update player on target position. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Undo(): void 
            - This method will update undo button while playing the game
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None
        - Reset(): void
            - This method will update reset game while playing the game. 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## SpawnPlayer
    Class Purpose: This Class will handles SpawnPlayer for single player 
    
    Data Fields:
    - playerPrefab
        - Type: GameObject
    - minX
        - Type: float
    - Max	
        - Type: float
    - minY
        - Type: float 
    - maxY
        - Type: float 

    Method:
        - Start(): void 
            - This method will start the game 
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## Animator  
    Class Purpose: Handles Animation for single player
    
    Methods:
        - Controller():
            - Purpose: Holds code that will communicate with other methods in order to animate base game.
            - Pre-Conditoins: None 
            - Parameters: None
            - Returns: None

## PhotonAnimatorview  
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

## PhotonTransformViewClassic  
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

## PhotonView   
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










 


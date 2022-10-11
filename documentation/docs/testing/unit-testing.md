---
sidebar_position: 1
---
# Unit tests
1. MainMenuOperator 
    - Procedure: User will allow to traverse between the leaderboard, single player and multiplayer aspects of the game 
    - Test: TestMainMenu()
    - Input: void()
    - Output: A new row containing the input datashould be inserted in AWS Databse   if successful. If there is no new row being inserted to the table. 
    - Result: Success, the corresponding input values are sent to the AWS Database table.


2. AccountHandler 
    - Procedure: account handler class will send the user login data to the API, which will checked with the current data in the database, if correct user will be logged in, and incorrect user will be notified that information entered was wrong and they will need to re enter the data or continue as guest.
    - Test:AccountHandler()
    - Input: username- String(), Password- String()
    - Output:  if login credential are correct, the user will be pop message ”you have successfully login”. If login credential are incorrect, the user will be pop message “incorrect values”. This user will have a option to either register as a new user or enter as guest. 
    - Result: User will be authorised based on this authentication system. 


3.  Leaderboard
    - Procedure: When we press leaderboard button we are able to see rank of other players including us. It also display high scope or points collected a by particular player.
    - Test: Leaderboard()
    - Input: Getinfo(), SortBy(obj)
    - Output: Once the test function receives the ClickEvent, User will able to see the list of players with there perspective rank.
    - Result: User will able to see the list of players with there perspective rank


4. ConnectionToServer 
    - Procedure: This class to communicate with our photon server and an online connection so when the player is ready they may play online with their peers
    - Test: ConnectionToServer()
    - Input:OnConnctedToMaster(), OnJoinedLobby(), OnDisconnected()
    - Output: Once Connected to master server, player will be taken to the lobby to either join existing room or create new room, When player disconnected to server they will be ask to rejoin the server in the given timeframe. 
    - Result: Player will be successfully connected to the master server and get into the lobby.  


5. CreateandJoinRoom
    - Procedure: This will allow a player to either host their own game and allow other to join on the room, or hope into game hosted by another. 
    - Test: CreateandJoinRoom()
    - Input: CreateRoom(),JoinRoom(), OnJoinedRoom(), OnCreateRoomFailed(),       OnJoinRoomFailed(), LeaveRoom(), OnLeftRoom()
    - Output: Once a player create a room, other player will be notified to join this room. Once join room, Players have option to stay in room to play the game or leave this room to exit. On failed to create room player will be prom to create room again or join existing one. 
    -  Result: Player will be able to create,join and play with friends or other player in a server room.


6. Transform
    - Procedure: Transform that Handle position of the player 
    - Test: TestTransform()
    - Input: Position(), Rotation(), Scale()
    - Result: This component will ensure that prefab is in correct position, rotation and scale.


7. SpriteRenderer
    - Procedure: This render the player sprite means character icon 
    - Test: TestSpriterenderer()
    - Input: Sprite()
    - Result: This component shows the player sprite withit respective graphic texture.


8. RigitBody2D
    - Procedure: For this handles hit box of player 
    - Test: TestRigidBody2D()
    - Input: Mass()
    - Output: Due to mass and gravity the player character will fall down and needs to be stop by a ground collider. 
    - Result: This component enable to implement real world physics in the game. 


9. BoxCollider2D
    - Procedure: For this Handkes hit box of boxes, this box is actual object the interacts with the boxes. 
    - Test: TestBoxCollider2D()
    - Input: Offset(), Size()
    - Output: Collider needs to fit the shape and size of the sprite. 
    - Result: This component allows to detect collison between two game object. 


10. BoxController
    - Procedure: For this meghof handlers all logic of the boxes location, movement, and weather they are on right spot. 
    - Test: TestBoxController()
    - Input: Update(), OnEnterCollosion()
    - Output: Player’s movement mechanism and collison detection is achieve. 
    - Result: Player character will be control using keyboard and mouse inputs. 

11. Animator
    - Procedure: For this method handler animation for multiplayer 
    - Test: TestAnimator()
    - Input: Controller()
    - Output:  If player moves in left direction left animation is play and if player moves in right direction, right animation is play. 
    - Result:  Player movement animation achieve 

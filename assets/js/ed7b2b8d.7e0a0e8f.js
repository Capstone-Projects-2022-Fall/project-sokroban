"use strict";(self.webpackChunktu_cis_4398_docs_template=self.webpackChunktu_cis_4398_docs_template||[]).push([[3961],{3905:function(e,t,a){a.d(t,{Zo:function(){return h},kt:function(){return d}});var n=a(67294);function l(e,t,a){return t in e?Object.defineProperty(e,t,{value:a,enumerable:!0,configurable:!0,writable:!0}):e[t]=a,e}function s(e,t){var a=Object.keys(e);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);t&&(n=n.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),a.push.apply(a,n)}return a}function r(e){for(var t=1;t<arguments.length;t++){var a=null!=arguments[t]?arguments[t]:{};t%2?s(Object(a),!0).forEach((function(t){l(e,t,a[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(a)):s(Object(a)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(a,t))}))}return e}function i(e,t){if(null==e)return{};var a,n,l=function(e,t){if(null==e)return{};var a,n,l={},s=Object.keys(e);for(n=0;n<s.length;n++)a=s[n],t.indexOf(a)>=0||(l[a]=e[a]);return l}(e,t);if(Object.getOwnPropertySymbols){var s=Object.getOwnPropertySymbols(e);for(n=0;n<s.length;n++)a=s[n],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(l[a]=e[a])}return l}var o=n.createContext({}),c=function(e){var t=n.useContext(o),a=t;return e&&(a="function"==typeof e?e(t):r(r({},t),e)),a},h=function(e){var t=c(e.components);return n.createElement(o.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return n.createElement(n.Fragment,{},t)}},p=n.forwardRef((function(e,t){var a=e.components,l=e.mdxType,s=e.originalType,o=e.parentName,h=i(e,["components","mdxType","originalType","parentName"]),p=c(a),d=l,m=p["".concat(o,".").concat(d)]||p[d]||u[d]||s;return a?n.createElement(m,r(r({ref:t},h),{},{components:a})):n.createElement(m,r({ref:t},h))}));function d(e,t){var a=arguments,l=t&&t.mdxType;if("string"==typeof e||l){var s=a.length,r=new Array(s);r[0]=p;var i={};for(var o in t)hasOwnProperty.call(t,o)&&(i[o]=t[o]);i.originalType=e,i.mdxType="string"==typeof e?e:l,r[1]=i;for(var c=2;c<s;c++)r[c]=a[c];return n.createElement.apply(null,r)}return n.createElement.apply(null,a)}p.displayName="MDXCreateElement"},55531:function(e,t,a){a.r(t),a.d(t,{assets:function(){return h},contentTitle:function(){return o},default:function(){return d},frontMatter:function(){return i},metadata:function(){return c},toc:function(){return u}});var n=a(83117),l=a(80102),s=(a(67294),a(3905)),r=["components"],i={sidebar_position:1},o="System Architecture",c={unversionedId:"system-architecture/design",id:"system-architecture/design",title:"System Architecture",description:"Database Table",source:"@site/docs/system-architecture/design.md",sourceDirName:"system-architecture",slug:"/system-architecture/design",permalink:"/project-sokroban/docs/system-architecture/design",draft:!1,editUrl:"https://github.com/Capstone-Projects-2022-Fall/project-sokroban/edit/main/documentation/docs/system-architecture/design.md",tags:[],version:"current",sidebarPosition:1,frontMatter:{sidebar_position:1},sidebar:"docsSidebar",previous:{title:"System Architecture",permalink:"/project-sokroban/docs/category/system-architecture"},next:{title:"API Specification",permalink:"/project-sokroban/docs/category/api-specification"}},h={},u=[{value:"Database Table",id:"database-table",level:2},{value:"API Diagram",id:"api-diagram",level:2},{value:"UML Diagram",id:"uml-diagram",level:2},{value:"UML Front-End Diagram",id:"uml-front-end-diagram",level:3},{value:"UML Back-End Diagram",id:"uml-back-end-diagram",level:3},{value:"Sequence Diagrams",id:"sequence-diagrams",level:2},{value:"Use Case 1: Player wants to successfully register their account and then exit the game",id:"use-case-1-player-wants-to-successfully-register-their-account-and-then-exit-the-game",level:3},{value:"Use Case 2: Player wants to play Normal Mode (Single Player)",id:"use-case-2-player-wants-to-play-normal-mode-single-player",level:3},{value:"Use Case 3: Player wants to play Challenge Mode",id:"use-case-3-player-wants-to-play-challenge-mode",level:3},{value:"Use Case 4: Player wants to play a game with a friend",id:"use-case-4-player-wants-to-play-a-game-with-a-friend",level:3},{value:"Use Case 5: Player wants to play a game against a friend",id:"use-case-5-player-wants-to-play-a-game-against-a-friend",level:3},{value:"Use Case 6: Player wants to check high scores",id:"use-case-6-player-wants-to-check-high-scores",level:3},{value:"Use Case 7: Player wins level",id:"use-case-7-player-wins-level",level:3},{value:"Use Case 8: Player gets stuck and resets the level",id:"use-case-8-player-gets-stuck-and-resets-the-level",level:3},{value:"Use Case 9: Player wants to play with a different character",id:"use-case-9-player-wants-to-play-with-a-different-character",level:3},{value:"Use Case 10: Player wants to challenge themselves onto a map with complex design",id:"use-case-10-player-wants-to-challenge-themselves-onto-a-map-with-complex-design",level:3}],p={toc:u};function d(e){var t=e.components,i=(0,l.Z)(e,r);return(0,s.kt)("wrapper",(0,n.Z)({},p,i,{components:t,mdxType:"MDXLayout"}),(0,s.kt)("h1",{id:"system-architecture"},"System Architecture"),(0,s.kt)("h2",{id:"database-table"},"Database Table"),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Database Table",src:a(9036).Z,width:"1759",height:"1359"})),(0,s.kt)("p",null,'Sokrobans reliance on a database is very minimal, though crucial. The DB will only need to store the players Username(varchar,NOT NUll), Password(varchar,NOT NULL), HighScore(int), best time(time), and level(int).UserName and Password are the only two fields in the DB that are marked as NOT NULL, due to the simple fact that a user must have an account in order to "save" any data. One table is all that will need to be created in order to store the inforamtion and be utilized to pass data back and forth between the API.'),(0,s.kt)("h2",{id:"api-diagram"},"API Diagram"),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"API Diagram",src:a(44346).Z,width:"522",height:"1015"})),(0,s.kt)("p",null,'Sokroban will utilize an RESTful API hosted via Azure to pass player data back and forth between the game and the database. A player\'s high score, best time and level will all be saved.The best time, high score, and level will be updated after every "run" the game will check with the DB to see if any of the fields have been topped and replace update the data in the table. There will also be a leaderboard that will display the table in the database (minus the user password of course) filtered by top score overall.'),(0,s.kt)("h2",{id:"uml-diagram"},"UML Diagram"),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"UML Diagram",src:a(95109).Z,width:"789",height:"866"})),(0,s.kt)("p",null,"At the top of this diagram we explore how classes interact with the UI. Firstly we have different components of the Game UI like Timer, Level Count etc. all interacting with the Game UI interface. We also show how scene managers like MainMenuManager interact with each other and the UI and with the Canvas. The Canvas is where all UI components are displayed."),(0,s.kt)("p",null,"In the center we focus on the multiplayer and API aspects of our game. The CreateAndJoinRoom and the ConnectionToServer classes handle the connection to Photon and the connection between the players. The leaderboard and AccountHandler, take care of the sign in/login and the leaderboard functions."),(0,s.kt)("p",null,"At the bottom our classes represent the level generation and how each class works with one another. A lot of the classes derive from another like, Templates deriving from Template, deriving from Cell each class taking care of a smaller part of the larger generation. Then when we reach the Level class we sum up all the calculations of the previous classes and produce a level which the LevelTranslator turn into a playable Unity level"),(0,s.kt)("p",null,"To the right we have the Unity objects. This mainly consists of prefabs like Player, Box, Wall, Ground, and Target. These are what the player will be using to interact and each of these prefabs is very important as they are using by the LevelGenerator to specify where to spawn each prefab. Each prefab also has connected components like Transform (showing position and size), Sprite Renderer (showing what the object will look like), and other classes that might give the object function, like movement and so on."),(0,s.kt)("h3",{id:"uml-front-end-diagram"},"UML Front-End Diagram"),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"UML Front-End Diagram",src:a(55311).Z,width:"2403",height:"1881"})),(0,s.kt)("h3",{id:"uml-back-end-diagram"},"UML Back-End Diagram"),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"UML Back-End Diagram",src:a(82474).Z,width:"1563",height:"2246"})),(0,s.kt)("h2",{id:"sequence-diagrams"},"Sequence Diagrams"),(0,s.kt)("h3",{id:"use-case-1-player-wants-to-successfully-register-their-account-and-then-exit-the-game"},"Use Case 1: Player wants to successfully register their account and then exit the game"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 1 Description"),(0,s.kt)("p",null,"1)\tPlayer upon opening the application is prompted to create an account or to sign in.",(0,s.kt)("br",null),"\n2)\tPlayer selects the option to create a new account.",(0,s.kt)("br",null),"\n3)\tPlayer inputs a username and a password.",(0,s.kt)("br",null),"\n4)  Upon completion, player logs into account with their credentials.",(0,s.kt)("br",null),"\n5)\tPlayer enters to the main Menu.",(0,s.kt)("br",null),"\n6)\tPlayer exits the game by pressing the \u201cX\u201d button.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Figure ",src:a(25911).Z,width:"791",height:"715"})),(0,s.kt)("h3",{id:"use-case-2-player-wants-to-play-normal-mode-single-player"},"Use Case 2: Player wants to play Normal Mode (Single Player)"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 2 Description"),(0,s.kt)("p",null,"1) Player selects the Single Player Mode option.",(0,s.kt)("br",null),"\n2) Player is viewing the three choices of Single Player.",(0,s.kt)("br",null),"\n3) Player selects Normal Mode.",(0,s.kt)("br",null),"\n4) A level is generated for the player.",(0,s.kt)("br",null),"\n5) Player is now playing the game.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Figure2",src:a(48861).Z,width:"1268",height:"770"})),(0,s.kt)("h3",{id:"use-case-3-player-wants-to-play-challenge-mode"},"Use Case 3: Player wants to play Challenge Mode"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 3 Description"),(0,s.kt)("p",null,"1) Player selects the Single Player Mode option.",(0,s.kt)("br",null),"\n2) Player is viewing the three choices of Single Player.",(0,s.kt)("br",null),"\n3) A level is generated for the player. ",(0,s.kt)("br",null),"\n4) Player is now playing the game without the reset or undo buttons available.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(64674).Z,width:"1272",height:"772"})),(0,s.kt)("h3",{id:"use-case-4-player-wants-to-play-a-game-with-a-friend"},"Use Case 4: Player wants to play a game with a friend"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 4 Description"),(0,s.kt)("p",null,"1)  Player selects the Multiplayer Mode option. ",(0,s.kt)("br",null),"\n2)  Player selects the Co-op option. ",(0,s.kt)("br",null),"\n3)  Player sets up a lobby by creating a room and tells their friend the name of the room to join.",(0,s.kt)("br",null),"\n4)  Both players are on the same map.",(0,s.kt)("br",null),"\n5)  Players are helping each other in order to win the level.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(74392).Z,width:"1207",height:"1138"})),(0,s.kt)("h3",{id:"use-case-5-player-wants-to-play-a-game-against-a-friend"},"Use Case 5: Player wants to play a game against a friend"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 5 Description"),(0,s.kt)("p",null,"1)  Player selects the Multiplayer Mode option.",(0,s.kt)("br",null),"\n2)  Player selects the VS option.",(0,s.kt)("br",null),"\n3)  Player sets up a lobby by creating a room and tells their friend the name of the room to join.",(0,s.kt)("br",null),"\n4)  Players are competing on the same level in a split-screen.",(0,s.kt)("br",null),"\n5)\tPlayer gets the boxes into the end point faster than their friend.",(0,s.kt)("br",null),"\n6)  Player won the game.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(42947).Z,width:"1207",height:"1138"})),(0,s.kt)("h3",{id:"use-case-6-player-wants-to-check-high-scores"},"Use Case 6: Player wants to check high scores"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 6 Description"),(0,s.kt)("p",null,"1)\tPlayer selects the High Scores option.",(0,s.kt)("br",null),"\n2)\tPlayer views high scores.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(40467).Z,width:"920",height:"575"})),(0,s.kt)("h3",{id:"use-case-7-player-wins-level"},"Use Case 7: Player wins level"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 7 Description"),(0,s.kt)("p",null,"1)\tPlayer selects Normal Mode option.",(0,s.kt)("br",null),"\n2)  A level is generated for the player.",(0,s.kt)("br",null),"\n3)  Player starts to move the character and push the box by using the arrows on the keyboard.",(0,s.kt)("br",null),"\n4)\tPlayer places the box onto the target.",(0,s.kt)("br",null),"\n5)\tPlayer wins the level.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(82029).Z,width:"1352",height:"856"})),(0,s.kt)("h3",{id:"use-case-8-player-gets-stuck-and-resets-the-level"},"Use Case 8: Player gets stuck and resets the level"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 8 Description"),(0,s.kt)("p",null,"1)\tPlayer selects Normal Mode option.",(0,s.kt)("br",null),"\n2)\tPlayer moves the character and pushes the box(es) trying to win the level.",(0,s.kt)("br",null),"\n3)\tPlayer realizes that got stuck by pushing a box onto the wall and won\u2019t be able to place the box onto the target.",(0,s.kt)("br",null),"\n4)\tPlayer resets the level by pressing the reset button.",(0,s.kt)("br",null),"\n5)\tThe level resets with the character and the box(es) back to their starting positions.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(43285).Z,width:"1829",height:"1297"})),(0,s.kt)("h3",{id:"use-case-9-player-wants-to-play-with-a-different-character"},"Use Case 9: Player wants to play with a different character"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 9 Description"),(0,s.kt)("p",null,"1)  Player selects Single Player option.",(0,s.kt)("br",null),"\n2)  Player selects their favorite character from a variety of characters.",(0,s.kt)("br",null),"\n3)  Player starts playing with the chosen character.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(81981).Z,width:"1203",height:"856"})),(0,s.kt)("h3",{id:"use-case-10-player-wants-to-challenge-themselves-onto-a-map-with-complex-design"},"Use Case 10: Player wants to challenge themselves onto a map with complex design"),(0,s.kt)("details",null,(0,s.kt)("summary",null,"Use Case 10 Description"),(0,s.kt)("p",null,"1)  Player selects Single Player option.",(0,s.kt)("br",null),"\n2)  Player selects from a variety of maps with complex deisgn.",(0,s.kt)("br",null),"\n3)  Player plays the game with a more complex designed map.",(0,s.kt)("br",null))),(0,s.kt)("p",null,(0,s.kt)("img",{alt:"Use Case 1 Sequence Diagram",src:a(26044).Z,width:"686",height:"575"})))}d.isMDXComponent=!0},44346:function(e,t,a){t.Z=a.p+"assets/images/API-4e2c113ad2899351fe59c6b0e94fd2c5.png"},9036:function(e,t,a){t.Z=a.p+"assets/images/ERD-bfee36dc01edb729eef1b590d56e54ab.png"},82474:function(e,t,a){t.Z=a.p+"assets/images/Sokroban_Back_End-deecff7a7bd264c205a18e7b5f815b79.png"},55311:function(e,t,a){t.Z=a.p+"assets/images/Sokroban_Front_End-0ab9ca332815c2c10ca183ea0404da19.png"},95109:function(e,t,a){t.Z=a.p+"assets/images/UML_SOK-a2c95405588e501b29ca68c10517863e.png"},26044:function(e,t,a){t.Z=a.p+"assets/images/UseCase10pic-9c9489e625c83f9927aa5fa4b94c62ef.png"},25911:function(e,t,a){t.Z=a.p+"assets/images/UseCase1pic-36dcd8f56d58630f2698d1e5be95f2ff.png"},48861:function(e,t,a){t.Z=a.p+"assets/images/UseCase2pic-6d1676c5fc3f477112fdbf8030c07743.png"},64674:function(e,t,a){t.Z=a.p+"assets/images/UseCase3pic-a6e831bce1ac8475fd46a3caabecb5b5.png"},74392:function(e,t,a){t.Z=a.p+"assets/images/UseCase4pic-71762a13a36cdc9b4cc714f9bcbaa969.png"},42947:function(e,t,a){t.Z=a.p+"assets/images/UseCase5pic-1d09de6dea8898cbcd4845076a944b18.png"},40467:function(e,t,a){t.Z=a.p+"assets/images/UseCase6pic-74ea11cd3e0df8b594e17c9199876db8.png"},82029:function(e,t,a){t.Z=a.p+"assets/images/UseCase7pic-54b72e89ce6b0b8389a936de61cde9f8.png"},43285:function(e,t,a){t.Z=a.p+"assets/images/UseCase8pic-1dda7314b7a815294cd1ecfdb83aafc9.png"},81981:function(e,t,a){t.Z=a.p+"assets/images/UseCase9pic-faa62b235333770038a4d5094d689b5f.png"}}]);
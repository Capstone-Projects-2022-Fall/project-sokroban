"use strict";(self.webpackChunktu_cis_4398_docs_template=self.webpackChunktu_cis_4398_docs_template||[]).push([[6654],{3905:function(e,t,a){a.d(t,{Zo:function(){return p},kt:function(){return h}});var r=a(67294);function l(e,t,a){return t in e?Object.defineProperty(e,t,{value:a,enumerable:!0,configurable:!0,writable:!0}):e[t]=a,e}function n(e,t){var a=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),a.push.apply(a,r)}return a}function i(e){for(var t=1;t<arguments.length;t++){var a=null!=arguments[t]?arguments[t]:{};t%2?n(Object(a),!0).forEach((function(t){l(e,t,a[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(a)):n(Object(a)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(a,t))}))}return e}function o(e,t){if(null==e)return{};var a,r,l=function(e,t){if(null==e)return{};var a,r,l={},n=Object.keys(e);for(r=0;r<n.length;r++)a=n[r],t.indexOf(a)>=0||(l[a]=e[a]);return l}(e,t);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);for(r=0;r<n.length;r++)a=n[r],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(l[a]=e[a])}return l}var s=r.createContext({}),u=function(e){var t=r.useContext(s),a=t;return e&&(a="function"==typeof e?e(t):i(i({},t),e)),a},p=function(e){var t=u(e.components);return r.createElement(s.Provider,{value:t},e.children)},m={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},c=r.forwardRef((function(e,t){var a=e.components,l=e.mdxType,n=e.originalType,s=e.parentName,p=o(e,["components","mdxType","originalType","parentName"]),c=u(a),h=l,d=c["".concat(s,".").concat(h)]||c[h]||m[h]||n;return a?r.createElement(d,i(i({ref:t},p),{},{components:a})):r.createElement(d,i({ref:t},p))}));function h(e,t){var a=arguments,l=t&&t.mdxType;if("string"==typeof e||l){var n=a.length,i=new Array(n);i[0]=c;var o={};for(var s in t)hasOwnProperty.call(t,s)&&(o[s]=t[s]);o.originalType=e,o.mdxType="string"==typeof e?e:l,i[1]=o;for(var u=2;u<n;u++)i[u]=a[u];return r.createElement.apply(null,i)}return r.createElement.apply(null,a)}c.displayName="MDXCreateElement"},63144:function(e,t,a){a.r(t),a.d(t,{assets:function(){return p},contentTitle:function(){return s},default:function(){return h},frontMatter:function(){return o},metadata:function(){return u},toc:function(){return m}});var r=a(83117),l=a(80102),n=(a(67294),a(3905)),i=["components"],o={sidebar_position:1},s="Activities",u={unversionedId:"development-plan/activities",id:"development-plan/activities",title:"Activities",description:'During the requirements gathering every member of our team researched a different version of the original game "Sokoban". Our group decided to add different features that were missing from the original game. Our goal was to make the game more competitive, by adding a multiplayer option along with highscores, and finally, more interesting by adding a story mode.',source:"@site/docs/development-plan/activities.md",sourceDirName:"development-plan",slug:"/development-plan/activities",permalink:"/project-sokroban/docs/development-plan/activities",draft:!1,editUrl:"https://github.com/Capstone-Projects-2022-Fall/project-sokroban/edit/main/documentation/docs/development-plan/activities.md",tags:[],version:"current",sidebarPosition:1,frontMatter:{sidebar_position:1},sidebar:"docsSidebar",previous:{title:"Software Development Plan",permalink:"/project-sokroban/docs/category/software-development-plan"},next:{title:"Tasks",permalink:"/project-sokroban/docs/development-plan/tasks"}},p={},m=[],c={toc:m};function h(e){var t=e.components,a=(0,l.Z)(e,i);return(0,n.kt)("wrapper",(0,r.Z)({},c,a,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"activities"},"Activities"),(0,n.kt)("h1",{id:"requirements-gathering"},"Requirements Gathering"),(0,n.kt)("p",null,'During the requirements gathering every member of our team researched a different version of the original game "Sokoban". Our group decided to add different features that were missing from the original game. Our goal was to make the game more competitive, by adding a multiplayer option along with highscores, and finally, more interesting by adding a story mode.',(0,n.kt)("br",null),(0,n.kt)("br",{parentName:"p"}),"\n","Our team will also conduct User Acceptance Testing by providing different prototypes to users and ask them to perform different Use Cases. Based on the user's feedback and overall experience we will be updating our requirements accordingly in the future as the development goes on."),(0,n.kt)("h1",{id:"top-level-design"},"Top Level Design"),(0,n.kt)("ol",null,(0,n.kt)("li",{parentName:"ol"},"Create Login screen that will allow the user to log into their account or continue as guest."),(0,n.kt)("li",{parentName:"ol"},"Create cloud hosting server that will hold DB and API (utilizing AWS/Azure)."),(0,n.kt)("li",{parentName:"ol"},"Establish Database."),(0,n.kt)("li",{parentName:"ol"},"Establish an API that wil connect to our database and l take user login and allow them to retrieve previous scores/tines and upload new ones."),(0,n.kt)("li",{parentName:"ol"},"Create Main Menu that will allow the user to navigate to the 3 main areas of the game (Single player,Multiplayer,and Leaderboards)."),(0,n.kt)("li",{parentName:"ol"},"Create algorithm that will procedurally generate each level of the game."),(0,n.kt)("li",{parentName:"ol"},"Establish multiplayer server utilizing unitys photon networking service."),(0,n.kt)("li",{parentName:"ol"},"Create multiplayer co-op levels that will allow users to see a \u201cghost\u201d of their partner."),(0,n.kt)("li",{parentName:"ol"},"Create save function that will allow users to continue progress."),(0,n.kt)("li",{parentName:"ol"},"Build leaderboard page that will show users who hold the top scores/times.")),(0,n.kt)("h1",{id:"detailed-design"},"Detailed Design:"),(0,n.kt)("ol",null,(0,n.kt)("li",{parentName:"ol"},"Create login:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"The login page will be the first screen the player sees."),(0,n.kt)("li",{parentName:"ul"},"There will be a \u201clogin\u201d button."),(0,n.kt)("li",{parentName:"ul"},"There will be a \u201csign up\u201d button."),(0,n.kt)("li",{parentName:"ul"},"There will be a \u201cplay as guest\u201d button."))),(0,n.kt)("li",{parentName:"ol"},"Create cloud hosting:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Acquire a cloud server through AWS or Azure."),(0,n.kt)("li",{parentName:"ul"},"Hosts DB."),(0,n.kt)("li",{parentName:"ul"},"Hosts API."))),(0,n.kt)("li",{parentName:"ol"},"Create Database:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Using SSMS."),(0,n.kt)("li",{parentName:"ul"},"Will hold Usernames and Passwords."),(0,n.kt)("li",{parentName:"ul"},"Will keep record of a players high score and fastest time."))),(0,n.kt)("li",{parentName:"ol"},"Create API:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Create using .NET."),(0,n.kt)("li",{parentName:"ul"},"Host on AWS or Azure."),(0,n.kt)("li",{parentName:"ul"},"Will be used to pass data between Game and DB."))),(0,n.kt)("li",{parentName:"ol"},"Main Menu Interface:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"The interface will include:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Play button that further asks the player whether they want to play single-player or multiplayer."),(0,n.kt)("li",{parentName:"ul"},"Leaderboard button that shows the player what the leaderboard currently is."),(0,n.kt)("li",{parentName:"ul"},"An exit button for leaving the game."))))),(0,n.kt)("li",{parentName:"ol"},"Create levels for single-player/Story mode:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"There will be text bubbles that pop up during each level telling the story of the worker at the warehouse."),(0,n.kt)("li",{parentName:"ul"},"These text bubbles will also include a tutorial on what the controls are."),(0,n.kt)("li",{parentName:"ul"},"There will be a beginning few levels in single-player."))),(0,n.kt)("li",{parentName:"ol"},"Create a connection with the server:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"There will be a dedicated PhotonEngine server for the game."),(0,n.kt)("li",{parentName:"ul"},"When two players try to connect to each other they will be connecting to the server."))),(0,n.kt)("li",{parentName:"ol"},"Create multiplayer levels:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"There will be a choice whether to create or join a lobby and a text box that allows a name to be entered."),(0,n.kt)("li",{parentName:"ul"},"One player will create a lobby with a title."),(0,n.kt)("li",{parentName:"ul"},"The other player will put in the name and join the lobby."))),(0,n.kt)("li",{parentName:"ol"},"Save function:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"At the completion of every level, this will occur:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"The game will send the database the current level number as the furthest completed level."),(0,n.kt)("li",{parentName:"ul"},"The game will also send the high score of the player at the time that they beat the level."),(0,n.kt)("li",{parentName:"ul"},"This will make it so that when the player returns to the game their level progress will be saved."))))),(0,n.kt)("li",{parentName:"ol"},"Leaderboards Tab:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"There will be a button on the menu that leads to the leaderboards."),(0,n.kt)("li",{parentName:"ul"},"The score will be calculated based on the completion of each level, a score will be calculated based on moves and retries."),(0,n.kt)("li",{parentName:"ul"},"The score will reset when the game is exited, meaning, that when a player starts a level their score will be counting up until they exit to the menu or desktop."),(0,n.kt)("li",{parentName:"ul"},"Therefore in order to earn the most score possible, the player will need to start at level 1 and go all the way to the finish."),(0,n.kt)("li",{parentName:"ul"},"The high scores of everyone that has played the game will be posted on the leaderboards menu.")))),(0,n.kt)("h1",{id:"test"},"Test"),(0,n.kt)("ol",null,(0,n.kt)("li",{parentName:"ol"},"Unit Testing:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Play Mode tests: Our team will create unit tests that will test the execution of scripts required in a running scene."),(0,n.kt)("li",{parentName:"ul"},"Edit Mode tests: Our team will create unit tests that will test the scripts required for basic functionalities(s.a. direction class etc)."))),(0,n.kt)("li",{parentName:"ol"},"Functional Testing:",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Our team and others(we will select different people and ask them to try and complete our use cases) will test the functionality of our game and will try to look for any possible problems within our game or the user interface and the graphics, such as game mechanic issues, stability issues and game asset integrity."))),(0,n.kt)("li",{parentName:"ol"},"Compatibility Testing: ",(0,n.kt)("ul",{parentName:"li"},(0,n.kt)("li",{parentName:"ul"},"Our team will make sure our game is compatible across every machine it is supposed to run on.")))))}h.isMDXComponent=!0}}]);
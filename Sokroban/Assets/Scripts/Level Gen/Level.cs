using System;
using System.Collections;
using UnityEngine;

public class Level : MonoBehaviour
{
    private int floorCell;
    private int width;
    private int height;
    private int players;
    private Cell[,] map;
    private System.Random rand;

    public static int cratesCount;

    //Sandbox
    public Level(int crates) {
        rand = new System.Random();
        cratesCount = crates;
        width = 11; //rand(2,4)*3+2
        height = width;
        players = 1;
    }
    //SP Normal/Challenge Mode
    public Level(int crates, int size) {
        rand = new System.Random();
        cratesCount = crates;
        width = size; //rand(2,4)*3+2
        height = width;
        players = 1;
    }
    //Coop
    public Level(int crates, int size, int playerCount)
    {
        rand = new System.Random();
        cratesCount = crates;
        width = size; //rand(2,4)*3+2
        height = width;
        players = playerCount;
    }
    public void generate() {
        map = new Cell[width,height];
        floorCell = 0;

        //Wall generation around level
        for (int x = 0; x < width; x++) {
            map[0,x] = Cell.Wall;
            map[height-1,x] = Cell.Wall;
        }
        for (int y = 1; y < height-1; y++) {
            map[y,0] = Cell.Wall;
            map[y,width-1] = Cell.Wall;
        }
        
        //Template generation
        int attempt = 0;
        for (int x = 1; x < width-2; x+= 3) {
            for (int y = 1; y < height-2; y += 3) {

                Template randomTemplate = Templates.getRandom();
                randomTemplate.randomRotation();

                while (placementAllowed(randomTemplate, x, y) != true)
                {
                    randomTemplate = Templates.getRandom();
                    randomTemplate.randomRotation();
                    if (attempt > 100)
                    {
                        Debug.Log("Max attemp reach, please generate again");
                        return;
                    }
                    attempt++;
                }

                placeTemplate(randomTemplate, x, y);
            }
        }
    }

    private bool spawnCratesMP(int n) {
        //The methods to generate the crate used right now should be done for multiplayer
        //The methods for single player should be changed to making sure there are not walls
        //Directly adjacent it the crate. The way it is now, sometimes there is no way to get 
        //A crate away from the wall without another player, this could be fun for coop but unsolvable in SP
        int x, y, surroundWall,surroundCrate, attempt = 0;
        for (int i = 0; i < n; i++) {

            do {
                x = rand.Next(2, width-2);
                y = rand.Next(2, height-2);

                surroundWall = 0;
                surroundWall += (map[x-1,y] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x+1,y] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x,y-1] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x, y + 1] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x-1, y-1] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x+1, y+1] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x+1, y-1] == Cell.Wall) ? 1 : 0;
                surroundWall += (map[x-1, y+1] == Cell.Wall) ? 1 : 0;

                surroundCrate = 0;
                surroundCrate += (map[x - 1, y] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x, y + 1] == Cell.Crate) ? 1 : 0;
                /* Diagonal check
                surroundCrate += (map[x - 1, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y + 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x - 1, y + 1] == Cell.Crate) ? 1 : 0;
                */


                if (surroundWall >= 2)
                {
                    removeWalls(x,y, surroundWall);
                }

                if (attempt >= floorCell) {
                    Debug.Log("Can't generate crates ! Max attempt reach");
                    return false;
                }
                attempt++;
            } while(map[x,y] != Cell.Floor || surroundCrate >= 1);
            Debug.Log("Crate proximity:" + surroundCrate + " crate(s) " + surroundWall + " wall(s)");
            map[x,y] = Cell.Crate;
        }
        return true;
    }

    private bool spawnCratesSP(int n)
    {
        //This algorithms makes sure there are no walls directly adjacent to the crate

        int x, y, surroundAdjacentWall, surrounDiagonalWall, surroundCrate, attempt = 0;
        for (int i = 0; i < n; i++)
        {
            do
            {
                x = rand.Next(2, width - 2);
                y = rand.Next(2, height - 2);

                surroundAdjacentWall = 0;
                surroundAdjacentWall += (map[x - 1, y] == Cell.Wall) ? 1 : 0;
                surroundAdjacentWall += (map[x + 1, y] == Cell.Wall) ? 1 : 0;
                surroundAdjacentWall += (map[x, y - 1] == Cell.Wall) ? 1 : 0;
                surroundAdjacentWall += (map[x, y + 1] == Cell.Wall) ? 1 : 0;

                surrounDiagonalWall = 0;
                surrounDiagonalWall += (map[x - 1, y - 1] == Cell.Wall) ? 1 : 0;
                surrounDiagonalWall += (map[x - 1, y + 1] == Cell.Wall) ? 1 : 0;
                surrounDiagonalWall += (map[x + 1, y - 1] == Cell.Wall) ? 1 : 0;
                surrounDiagonalWall += (map[x + 1, y + 1] == Cell.Wall) ? 1 : 0;

                surroundCrate = 0;
                surroundCrate += (map[x - 1, y] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x, y + 1] == Cell.Crate) ? 1 : 0;
                /* Diagonal check
                surroundCrate += (map[x - 1, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y + 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x - 1, y + 1] == Cell.Crate) ? 1 : 0;
                */

                if (attempt >= floorCell)
                {
                    Debug.Log("Can't generate crates ! Max attempt reach");
                    return false;
                }
                attempt++;
                                                // One surrounding crates, no adjecent walls, only 1 diagnoal wall allowed
            } while (map[x, y] != Cell.Floor || surroundCrate >= 1 || surroundAdjacentWall > 0 ||surrounDiagonalWall >1);
            Debug.Log("Crate proximity:" + surroundCrate + " crate(s) " + surroundAdjacentWall + " wall(s)");
            map[x, y] = Cell.Crate;
        }
        return true;
    }

    private bool spawnPlayer(int n) {
        int x, y, attempt = 0;
        for (int i = 0; i < n; i++)
        {
            do
            {
                x = rand.Next(1, width - 1);
                y = rand.Next(1, height - 1);

                if (attempt >= floorCell)
                {
                    Debug.Log("Can't generate player ! Max attempt reach");
                    return false;
                }
                attempt++;

            } while (map[x, y] != Cell.Floor);

            map[x, y] = Cell.Player;
        }
        return true;
    }

    private bool spawnGoals(int n) {
        int x, y, attempt = 0,hasValidPath, surroundCrate;
        for (int i = 0; i < n; i++) {
            do {
                
                x = rand.Next(1, width-1);
                y = rand.Next(1, height-1);

                hasValidPath = 0;
                hasValidPath += (map[x, y + 1] != Cell.Wall && map[x, y + 2] != Cell.Wall) ? 1 : 0;
                hasValidPath += (map[x, y - 1] != Cell.Wall && map[x, y - 2] != Cell.Wall) ? 1 : 0;
                hasValidPath += (map[x + 1, y] != Cell.Wall && map[x + 2, y] != Cell.Wall) ? 1 : 0;
                hasValidPath += (map[x - 1, y] != Cell.Wall && map[x - 2, y] != Cell.Wall) ? 1 : 0;

                surroundCrate = 0;
                surroundCrate += (map[x, y + 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x, y - 1] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x + 1, y] == Cell.Crate) ? 1 : 0;
                surroundCrate += (map[x - 1, y] == Cell.Crate) ? 1 : 0;

                if (attempt >= floorCell) {
                    Debug.Log("Can't generate goals ! Max attemp reach");
                    return false;
                }
                attempt++;

            } while(map[x,y] != Cell.Floor || hasValidPath <= 2 || surroundCrate >= 1);

            map[x,y] = Cell.Goal;
        }
        return true;
    }

    private void removeNull()
    {
        for (int x = 1; x < width-1; x++)
        {
            for (int y = 1; y < height-1; y++)
            {
                if (map[x, y] == Cell.Null) { map[x , y] = Cell.Wall; };
            }
        } 
    }
    private void removeWalls(int currentX, int currentY, int surroundWall)
    {
        var wallCells = new ArrayList();

        //Will add all walls to a list, number is used as identifier for switch
        if (map[currentX - 1, currentY] == Cell.Wall) { wallCells.Add(1); };
        if (map[currentX + 1, currentY] == Cell.Wall) { wallCells.Add(2); };
        if (map[currentX, currentY - 1] == Cell.Wall) { wallCells.Add(3); };
        if (map[currentX, currentY + 1] == Cell.Wall) { wallCells.Add(4); };
        if (map[currentX - 1, currentY - 1] == Cell.Wall) { wallCells.Add(5); };
        if (map[currentX + 1, currentY + 1] == Cell.Wall) { wallCells.Add(6); };
        if (map[currentX + 1, currentY - 1] == Cell.Wall) { wallCells.Add(7); };
        if (map[currentX - 1, currentY + 1] == Cell.Wall) { wallCells.Add(8); };

        //loop for however many surrounding walls, keep 1
        for (int i = surroundWall; i > 1; i--)
        {
            // will randomly remove one wall for list
            int randNum = rand.Next(0, wallCells.Count);
            switch (wallCells[randNum])
            {
                case 1:
                    map[currentX - 1, currentY] = Cell.Floor;
                    break;
                case 2:
                    map[currentX + 1, currentY] = Cell.Floor;
                    break;
                case 3:
                    map[currentX, currentY - 1] = Cell.Floor;
                    break;
                case 4:
                    map[currentX, currentY + 1] = Cell.Floor;
                    break;
                case 5:
                    map[currentX - 1, currentY - 1] = Cell.Floor;
                    break;
                case 6:
                    map[currentX + 1, currentY + 1] = Cell.Floor;
                    break;
                case 7:
                    map[currentX + 1, currentY - 1] = Cell.Floor;
                    break;
                case 8:
                    map[currentX - 1, currentY + 1] = Cell.Floor;
                    break;
            }
            wallCells.RemoveAt(randNum);
        }
    }
    public void postProcess() {
        cleanUselessRoom();
        //cleanAloneWall();
        //To optimize, before spawning crates mark all deadCell
        //Spawn Crate only on non deacCell
        //Need to improve deadCell algorithm too
        removeNull();
        cleanDeadCell();
        if (MainMenuManager.isMultiplayer)
        {
            spawnCratesMP(cratesCount);
        }
        else
        {
            spawnCratesSP(cratesCount);
        }
        spawnGoals(cratesCount);
        spawnPlayer(players);
    }

    //Checks all surrounding blocks, with main block in the middle
    //If all blocks are floor, the main block should be floor too
    private void cleanAloneWall() {
        for(int x = 1; x < width-1; x++) {
            for (int y = 1; y < height-1; y++) {
                if (map[x,y] == Cell.Wall) {
                    int surroundFloor = 0;
                    surroundFloor += (map[x-1,y] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x+1,y] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x,y-1] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x,y+1] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x-1,y-1] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x+1,y-1] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x+1,y+1] == Cell.Floor) ? 1 : 0;
                    surroundFloor += (map[x+1,y-1] == Cell.Floor) ? 1 : 0;

                    if (surroundFloor > 6) {
                        if (rand.Next(0,100) < 30) {
                            map[x,y] = Cell.Floor;
                        }
                    }
                }
            }
        }
    }

    private bool cleanUselessRoom() {

        int filledFloor = 0;
        int attempt = 0;
        int x = rand.Next(1,width-1);
        int y = rand.Next(1,height-1);

        do
        {
            CellToWall(Cell.FloorFilled);
            while (map[x,y] != Cell.Floor) {
                x = rand.Next(1,width-1);
                y = rand.Next(1,height-1);
                if (attempt > width*height) {
                    return false;
                }
                attempt++;
            }
            filledFloor += floodFill(Cell.Floor, Cell.FloorFilled, x, y);
        } while (filledFloor < (int)floorCell * 0.5f);

        for(int i = 1; i < width; i++) {
            for (int j = 1; j < height; j++) {
                if (map[i,j] == Cell.Floor) {
                    map[i,j] = Cell.Wall;
                }
                else if (map[i,j] == Cell.FloorFilled) {
                    map[i,j] = Cell.Floor;
                }
            }
        }
        return true;
    }

    private void CellToWall(Cell type) {
        for(int x = 1; x < width; x++) {
            for (int y = 1; y < height; y++) {
                if (map[x,y] == type) {
                    map[x,y] = Cell.Wall;
                }
            }
        }
    }

    private int floodFill(Cell target, Cell replace, int x, int y) {
        int filledFloor = 0;
        if (target == replace) { return 0; }
        else if (map[x,y] != target) { return 0; }
        else { 
            map[x,y] = replace;
            filledFloor++;
        }

        if (x+1 < width-1) {
            filledFloor += floodFill(target, replace, x-1, y);
        }
        if (x-1 > 0) {
            filledFloor += floodFill(target, replace, x+1, y);
        }
        if (y+1 < height-1) {
            filledFloor += floodFill(target, replace, x, y+1);
        }
        if (y-1 > 0) {
            filledFloor += floodFill(target, replace, x, y-1);
        }

        return filledFloor;
    }

    private void cleanDeadCell() {
        for (int x = 1; x < width - 1; x++) {
            for (int y = 1; y < height -1; y++) {
                if (map[x,y] == Cell.Floor) {
                    int surroundWall = 0;
                    surroundWall += (map[x-1,y] == Cell.Wall) ? 1 : 0;
                    surroundWall += (map[x+1,y] == Cell.Wall) ? 1 : 0;
                    surroundWall += (map[x,y-1] == Cell.Wall) ? 1 : 0;
                    surroundWall += (map[x,y+1] == Cell.Wall) ? 1 : 0;
                    if (surroundWall >= 3) {
                        map[x,y] = Cell.Wall;
                    }
                }
            }
        }
    }

    private bool placementAllowed(Template template, int x, int y) {
        bool allowed = true;

        for (int i = -1; i < 4; i++) {
            if (x+i > -1 && x+i < width) {
                Cell upperCellMap = map[x+i,y-1];
                Cell lowerCellMap = map[x+i,y+3];
                if (upperCellMap != Cell.Null || lowerCellMap != Cell.Null) {
                    Cell upperCell = template.GetCell(i+1,0);
                    Cell lowerCell = template.GetCell(i+1,4);
                    
                    if (upperCell != Cell.Null && lowerCell != Cell.Null) {
                        if (upperCell != upperCellMap || lowerCell != lowerCellMap) {
                            allowed = false;
                            break;
                        }
                    }
                } 
            }
        }

        for (int j = 0; j < 4; j++) {
            if (y+j < height) {
                Cell leftCellMap = map[x-1,y+j];
                Cell rigthCellMap = map[x+3,y+j];
                if (leftCellMap != Cell.Null || rigthCellMap != Cell.Null) {
                    Cell leftCell = template.GetCell(0,j+1);
                    Cell rigthCell = template.GetCell(4,j+1);
                    if (leftCell != Cell.Null && rigthCell != Cell.Null) {
                        if (leftCell != leftCellMap || rigthCell != rigthCellMap) {
                            allowed = false;
                            break;
                        }
                    }
                }
            }
        }
        return allowed;
    }

    private void placeTemplate(Template template, int x, int y) {
        for(int i = -1; i < 4; i++) {
            for(int j = -1; j < 4; j++) {
                if (x+i > 0 && y+j > 0 && x+i < width-1 && y+j < height-1) {
                    Cell cell = template.GetCell(i+1,j+1);
                    if (cell != Cell.Null) {
                        if (cell == Cell.Floor) {
                            floorCell++;
                        }
                        map[x+i,y+j] = cell;
                    } 
                } 
            }
        }
    }

    public bool hasErrors()
    {
        bool badGeneration = false;
        int crateCount = 0,playerCount = 0,targetCount = 0, groundCount = 0;
        for (int x = 1; x < width - 1; x++)
        {
            for (int y = 1; y < height - 1; y++)
            {
                if (map[x, y] == Cell.Crate)
                {
                    crateCount++;
                }
                else if (map[x, y] == Cell.Player)
                {
                    playerCount++;
                }
                else if (map[x, y] == Cell.Goal)
                {
                    targetCount++;
                }
                else if (map[x, y] == Cell.Floor)
                {
                    groundCount++;
                }
            }
        }
        double playableArea = (double)((width-2) * (height-2));
        double percentEmpty = (double)groundCount / playableArea;
        Debug.Log("Percent Empty: " + percentEmpty +"  "+ crateCount +"/"+playerCount +"/"+ targetCount +" crates/players/target");
        //Should be amount specified by player
        if (playerCount < 1 || crateCount < cratesCount|| targetCount < cratesCount || percentEmpty >= .6) //can change this percent if map is too empty
        {
            badGeneration = true;
        }
        return badGeneration;
    }

    public override string ToString()
    {
        string ret = "";
        for(int x = 0; x < width; x++) {
            for(int y = 0; y < height; y++) {
                switch(map[x,y]) {
                    case Cell.Floor:
                        ret += " ";
                        break;
                    case Cell.Goal:
                        ret += ".";
                        break;
                    case Cell.Wall:
                        ret += "#";
                        break;
                    case Cell.Player:
                        ret += "@";
                        break;
                    case Cell.Crate:
                        ret += "$";
                        break;
                    default:
                        break;
                }
            }
            ret += "\n";
        }
        return ret;
    }

    public Cell[,] getMap()
    {
        return map;
    }
    public int getWidth()
    {
        return width;
    }
}
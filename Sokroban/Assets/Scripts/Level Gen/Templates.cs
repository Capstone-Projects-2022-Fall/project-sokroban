using System;
using System.Collections.Generic;
using UnityEngine;
public class Templates : MonoBehaviour
{
    private Cell[][] template1 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };
    private Cell[][] template2 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template3 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template4 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template5 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template6 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Floor, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template7 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template8 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Floor, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Floor, Cell.Null, Cell.Null},
    };

    private Cell[][] template9 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Floor, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Floor, Cell.Null, Cell.Null},
    };

    private Cell[][] template10 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Floor, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template11 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private Cell[][] template12 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Wall, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };
    private Cell[][] template13 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
    };

    private  Cell[][] template14 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Null, Cell.Null, Cell.Null},
    };

    private  Cell[][] template15 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Floor, Cell.Null, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Floor, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Null, Cell.Floor, Cell.Null},
    };

    private  Cell[][] template16 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
    };

    private  Cell[][] template17 = new Cell[][] {
        new Cell [] {Cell.Null, Cell.Null, Cell.Null, Cell.Null, Cell.Null},
        new Cell [] {Cell.Null, Cell.Wall, Cell.Wall, Cell.Wall, Cell.Null},
        new Cell [] {Cell.Floor, Cell.Floor, Cell.Wall, Cell.Floor, Cell.Floor},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Floor, Cell.Null},
        new Cell [] {Cell.Null, Cell.Floor, Cell.Floor, Cell.Null, Cell.Null},
    };

    private  List<Cell[][]> templates = new List<Cell[][]> {
        template1,
        template2,
        template3,
        template4,
        template5,
        template6,
        template7,
        template8,
        template9,
        template10,
        template11,
        template12,
        template13,
        template14,
        template15,
        template16,
        template17,
    };


    public Template getRandom() {
      //Random r = new Random();
      Cell[][] randTemplate = templates[Random.Range(templates.Count)];
      return new Template(randTemplate);
    }
}
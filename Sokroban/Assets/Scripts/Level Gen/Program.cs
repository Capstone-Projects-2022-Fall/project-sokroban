using System;
using System.IO;
using System.Text;
using UnityEngine;


public class Program : MonoBehaviour
{
    public static void Run()
    {
        Level level = new Level();

        level.generate();
        level.postProcess();
        //level.print();

        //export();
    }

    public static void export() {
        for (int i = 0; i < 10; i++) {
            Level level = new Level();
            level.generate();
            bool complete = level.postProcess();

            while(complete != true) {
                level.generate();
                complete = level.postProcess();
            }

            string path = "./Levels/" + i.ToString() + ".txt"; 
            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(level.ToString());
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                Debug.Log("Level " + i.ToString() + " exported to "+ path);
            }
            catch (Exception ex)
            {
                Debug.Log(ex.ToString());
            }
        }
    }
}


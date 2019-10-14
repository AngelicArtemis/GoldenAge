using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class LibraryControl : MonoBehaviour
{
    string ScreenCapDirectory = @"Assets\testing\";
    string ScreenCapName = "Pictures";
    public GameObject nonTaskLib;
    public GameObject lib;
    public GameObject taskLib;

    public GameObject clickSFX;
    int page = 0;
    int totalPages;
    int totalPics;

    public GameObject[] libPics = new GameObject[4]; //4 is the number of pics to display per screen
    int taskNum = 0;
    public GameObject marketLib;
    public GameObject toriLib;
    public GameObject towerLib;
    public GameObject cinemaLib;
    public GameObject kinkakujiLib;
    public GameObject stationLib;


    public struct Picture
    {
        public Texture2D pics;
        public string dir;
    }

    List<Picture> pictures = new List<Picture>();

    public struct Task
    {
        public Texture2D picture;
        public GameObject taskLib;
        public string name;
    }

    List<Task> completedTasks = new List<Task>();

    public void addCompletedTasks(string taskName)
    {
        Task tempo = new Task();
        for (int i = 0; i < Directory.GetFiles(ScreenCapDirectory).Length; i++) 
        {
            if (Directory.GetFiles(ScreenCapDirectory)[i].Contains(taskName) && Directory.GetFiles(ScreenCapDirectory)[i].EndsWith(".png"))
            {
                tempo.picture = LoadImage(Directory.GetFiles(ScreenCapDirectory)[i]);
            }
        }
        if(tempo.picture == null)
        {
            return;
        }
        tempo.name = taskName;
        tempo.taskLib = matchObjectToName(taskName);
        tempo.taskLib.GetComponentInChildren<RawImage>().texture = tempo.picture;
        completedTasks.Add(tempo);
    }

    void fillCompletedTask()
    {
        addCompletedTasks("tori");
        addCompletedTasks("market");
        addCompletedTasks("station");
        addCompletedTasks("tower");
        addCompletedTasks("cinema");
        addCompletedTasks("kinkakuji");
    }

    public void displayTaskLibPage()
    {
        if(completedTasks.Count > taskNum)
            completedTasks[taskNum].taskLib.SetActive(true);

    }

    public void nextTaskLibPage()
    {

        clickSFX.GetComponent<AudioSource>().Play();
        int prev = taskNum;
        taskNum += 1;
        if (taskNum >= completedTasks.Count)
            taskNum = 0;

        displayTaskLibPage();
        completedTasks[prev].taskLib.SetActive(false);
    }

    public void prevTaskLibPage()
    {

        clickSFX.GetComponent<AudioSource>().Play();
        int prev = taskNum;
        taskNum -= 1;
        if (taskNum < 0)
            taskNum = completedTasks.Count - 1;

        displayTaskLibPage();
        completedTasks[prev].taskLib.SetActive(false);
    }

    GameObject matchObjectToName(string taskname) //maybe put a loop and put the word in an array to loop through...eh we're still in testing
    {
        if (taskname.ToLower().Contains("tori"))
        {
            return toriLib;
        }
        else if (taskname.ToLower().Contains("market"))
        {
            return marketLib;
        }
        else if (taskname.ToLower().Contains("tower"))
        {
            return towerLib;
        }
        else if (taskname.ToLower().Contains("kinkakuji"))
        {
            return kinkakujiLib;
        }
        else if (taskname.ToLower().Contains("station"))
        {
            return stationLib;
        }
        else if (taskname.ToLower().Contains("cinema"))
        {
            return cinemaLib;
        }
        else
        {
            return null;
        }
    }

    public static Texture2D LoadImage(string filename)
    {
        byte[] bytes = File.ReadAllBytes(filename);

        Texture2D texture = new Texture2D(Screen.width, Screen.height);
        texture.LoadImage(bytes);

        return texture;
    }

    public void openLibs()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        lib.SetActive(true);
        taskLib.SetActive(false);
        nonTaskLib.SetActive(false);
    }
    public void DisplayTaskPics()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        lib.SetActive(false);
        taskLib.SetActive(true);
        fillCompletedTask();
        displayTaskLibPage();
    }

    public void NonTaskPics()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        lib.SetActive(false);
        nonTaskLib.SetActive(true);
        Init();
    }
    int FindScreenCaptures(string DirectoryPath, string FileName)
    {
        int count = 0;

        for (int i = 0; i < Directory.GetFiles(DirectoryPath).Length; i++)
        {
            if (Directory.GetFiles(DirectoryPath)[i].Contains(FileName) && Directory.GetFiles(DirectoryPath)[i].EndsWith(".png"))
            {
                count += 1;
            }
        }
        return count;
    }

    //NON TASK LIST PART
    public void Init()
    {
        pictures.Clear();
#if UNITY_EDITOR
        UnityEditor.AssetDatabase.Refresh();
#endif

        Picture temp;

        for (int i = 0; i < Directory.GetFiles(ScreenCapDirectory).Length; i++) //loads all the images into an array of texture
        {
            if (Directory.GetFiles(ScreenCapDirectory)[i].Contains(ScreenCapName) && Directory.GetFiles(ScreenCapDirectory)[i].EndsWith(".png"))
            {
                temp.pics = LoadImage(Directory.GetFiles(ScreenCapDirectory)[i]);
                temp.dir = Directory.GetFiles(ScreenCapDirectory)[i];
                pictures.Add(temp);
            }
        }

        totalPics = pictures.Count;
        totalPages = (int)Mathf.Ceil(totalPics/4);

        libDisplay(page);
    }

    public void nextPage()
    {

        clickSFX.GetComponent<AudioSource>().Play();
        page += 1;
        if (page > totalPages)
        {
            page = 0;
        }
        libDisplay(page);
    }

    public void previousPage()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        page -= 1;
        if (page < 0)
        {
            page = totalPages;
        }
        libDisplay(page);
    }




    public void libDisplay(int page)
    {
        for(int i=0; i<4;i++)
        {
            if(i + page * 4 < pictures.Count)
            {
                libPics[i].GetComponent<RawImage>().texture = pictures[i + page * 4].pics;
            }
            else
            {
                libPics[i].GetComponent<RawImage>().texture = null;
            }
        }
    }




    public void DeleteNonTaskPic(int picNum)
    {
        clickSFX.GetComponent<AudioSource>().Play();
        int targetPic = (page * 4) + picNum;

        if(targetPic > pictures.Count) //it dont exist
        {
            return;
        }
        Picture target = pictures[targetPic];
        string targetdir = target.dir;


        // check if file exists
        if (!File.Exists(targetdir))
        {
            //file doesnt exist, do nothing
            return;
        }
        else
        {
            //file exist, delete and reinitialize the library
            Debug.Log("deleting " + targetdir);
            File.Delete(targetdir);
            StartCoroutine(wait()); //small wait to make sure its deleted before refreshing
            Init();

#if UNITY_EDITOR
            UnityEditor.AssetDatabase.Refresh();
#endif
        }

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
    }

}

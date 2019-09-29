using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class TaskListManager : MonoBehaviour
{
    public GameObject[] tasks;
    int counter = 0;
    public GameObject complete;
    List<TaskList> completedKyotoTasks = new List<TaskList>(); 
    List<TaskList> completedLondonTasks = new List<TaskList>();
    public int numberOfTaskInKyoto;
    public GameObject clickSFX;

    public void taskChecker(TaskList taskList)
    {
        if(FindObjectOfType<ScreenCaptureManager>().taskListCheck(taskList.taskName))
        {
            taskList.taskCompletion = true;
            if(SceneManager.GetSceneAt(1).name == "lvl1")
                addsCompleted(completedKyotoTasks, taskList);
            if(SceneManager.GetSceneAt(1).name == "lvl2")
                addsCompleted(completedLondonTasks, taskList);
        }
        else
        {
            taskList.taskCompletion = false;
        }

    }

    void addsCompleted(List<TaskList> city, TaskList task) //use this for lib display one day lol when there's lib
    {
        for(int i=0; i < city.Count; i++)
        {
            if(city[i].taskName == task.taskName)
            {
                return;
            }
        }
        city.Add(task);
    }


    public string checkTaskPicCity(string picName)
    {
        for(int i=0; i < completedKyotoTasks.Count; i++)
        {
            if(picName == completedKyotoTasks[i].taskName)
            {
                return "kyoto";
            }

        }
        return "london";
    }

    bool taskCheckerName(string taskname)
    {
        if (FindObjectOfType<ScreenCaptureManager>().taskListCheck(taskname))
        {
            return true;
        }
        return false;
    }

    public void displayTasks()
    {
        tasks[counter].SetActive(true);
        if(taskCheckerName(tasks[counter].name))
        {
            complete.SetActive(true);
        }
        else
        {
            complete.SetActive(false);
        }
    }

    public void displayNext()
    {

        clickSFX.GetComponent<AudioSource>().Play();
        counter += 1;
        if (counter >= tasks.Length)
        {
            counter = 0;
            tasks[tasks.Length - 1].SetActive(false);
            displayTasks();
            return;
        }
        tasks[counter - 1].SetActive(false);
        displayTasks();
    }

    public void displayPrevious()
    {
        clickSFX.GetComponent<AudioSource>().Play();
        counter -= 1;
        if (counter < 0)
        {
            counter = tasks.Length -1;
            tasks[0].SetActive(false);
            displayTasks();
            return;
        }
        tasks[counter + 1].SetActive(false);
        displayTasks();
    }
}

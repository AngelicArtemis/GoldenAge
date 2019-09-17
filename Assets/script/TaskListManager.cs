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
    List<TaskList> completedKyotoTasks = new List<TaskList>(); //if we get to london we'll make a list for london okei?

    public void taskChecker(TaskList taskList)
    {
        if(FindObjectOfType<ScreenCaptureManager>().taskListCheck(taskList.taskName))
        {
            taskList.taskCompletion = true;
            if(SceneManager.GetSceneAt(1).name == "lvl1" )
            {
                addsCompleted(completedKyotoTasks, taskList);
            }
        }

    }

    void addsCompleted(List<TaskList> city, TaskList task) //use this for lib display one day lol when there's more then one city in the lib
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


}

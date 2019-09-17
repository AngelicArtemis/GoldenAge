using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TaskListManager : MonoBehaviour
{
    public GameObject[] tasks;
    int counter = 0;
    public GameObject complete;

    public void taskChecker(TaskList taskList)
    {
        if(FindObjectOfType<ScreenCaptureManager>().taskListCheck(taskList.taskName))
        {
            taskList.taskCompletion = true;
        }

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

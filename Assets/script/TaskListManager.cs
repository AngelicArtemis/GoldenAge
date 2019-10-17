using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class TaskListManager : MonoBehaviour
{
    public GameObject[] tasks;
    static int counter = 0;
    public GameObject complete;
    public List<TaskList> completedTasks = new List<TaskList>(); 
    public int numberOfTaskInKyoto;
    public GameObject clickSFX;


    public void taskChecker(TaskList taskList)
    {
        if(FindObjectOfType<ScreenCaptureManager>().taskListCheck(taskList.taskName))
        {
            taskList.taskCompletion = true;
            completedTasks.Add(taskList);
            //FindObjectOfType<LibraryControl>().addCompletedTasks(taskList.taskName);
        }
        else
        {
            taskList.taskCompletion = false;
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
        Debug.Log("counter" + counter);

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
        if (counter >= 6 )
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

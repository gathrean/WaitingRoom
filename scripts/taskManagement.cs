using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskManagement : MonoBehaviour
{

    public taskDisplay taskDisplay;
    
    public int taskCount;
    public GameObject taskTrigger;

    public class Task
    {
        public string taskName;
        public string taskObjective;
        public int taskPriority;
        public bool taskActive;
        public bool taskComplete;
        public string taskType;
        public int taskID;

        public Task(string name, string objective, int priority, bool active, bool complete, string type, int ID)
        {
            taskName = "Default Task Name";
            taskObjective = "Default objective text.";
            taskPriority = 999;
            taskActive = false;
            taskComplete = false;
            taskType = "none";
            taskID = 110000;
        }

        public string getName()
        {
            return taskName;
        }

        public string getObj()
        {
            return taskObjective;
        }
    };


    public List<Task> tasksActive = new List<Task>
    {
        new Task("dummy", "dummy", 999, false, false, "dummy", 110000)
    };
    public List<Task> taskComplete;

    Task defaultTask = new Task("dummy", "dummy", 999, false, false, "dummy", 110000);

    // Start is called before the first frame update
    void Start()
    {
        taskCount = 0;
        Debug.Log("number of tasks: " + taskCount);
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    //Creates task, called by outside scripts
    public int makeTask(string taskNameIN, string objective, int priority, bool active, bool complete, string type, int ID)
    {
        tasksActive.Add(new Task(taskNameIN, objective, priority, active, complete, type, ID) 
        {
            taskName = taskNameIN,
            taskObjective = objective,
            taskPriority = priority,
            taskActive = active,
            taskComplete = complete,
            taskType = type,
            taskID = ID
        }
        );

        return (tasksActive.Count - 1);
    }

    public void completeTask(int ID)
    {
        for(int i = 0; i <= (tasksActive.Count - 1); i++)
        {
            Debug.Log("taskManagement.cs: completeTask: for loop at i=" + i);

            int checkID = tasksActive[ID].taskID;

            if(checkID == ID)
            {
                Debug.Log("taskManagement.cs: completeTask: match found!");

                taskComplete.Add(new Task(tasksActive[i].taskName,tasksActive[i].taskObjective,tasksActive[i].taskPriority,false,true,tasksActive[i].taskType,tasksActive[i].taskID));
                Debug.Log("taskManagement.cs: completeTask: active Task moved to taskComplete list");
                tasksActive.RemoveAt(i);
                Debug.Log("taskManagement.cs: completeTask: completed Task removed from tasksActive list");

                // ID in tasksActive

                return;
            }
            else
            {
                Debug.Log("taskManagement.cs: completeTask: no match at i=" + i);
            };
            //taskComplete
        }
    }
}

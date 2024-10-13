using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskGiver : MonoBehaviour
{
    public taskManagement taskManag;
    public taskDisplay taskDisplay;
    public string itaskName;
    public string itaskObjective;
    public int itaskPriority;
    public bool itaskActive;
    public bool itaskComplete;
    public string itaskType;
    public int itaskID;
    
    public void taskManagerCall()
    {
        taskManagement taskManager = new taskManagement();
    }

    // Start is called before the first frame update
    void Start()
    {
        taskManagerCall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Adds task to active tasks list once player clicks
    void OnMouseDown()
    {
        var IDexists = false;

        // Cycles through all active tasks to check if the task is already added
        for(int i = 0; i <= (taskManag.tasksActive.Count - 1); i++)
        {
            Debug.Log("taskGiver.cs: OnMouseDown(): return value of checkActiveIDexists() = " + taskManag.checkActiveIDexists(itaskID, i));

            // Determines whether the task already exists at given index (identified by matching task ID)
            if(taskManag.checkActiveIDexists(itaskID, i))
            {
                IDexists = true;
                Debug.Log("taskGiver.cs: OnMouseDown(): ID match found -- IDexists = " + IDexists);
            }
        }

        Debug.Log("taskGiver.cs: OnMouseDown(): after check -- IDexists = "+ IDexists);

        // Adds task to active tasks list and updates display if it no matching ID is found
        if(IDexists == false)
        {
            var i = taskManag.makeTask(itaskName, itaskObjective, itaskPriority, true, false, itaskType, itaskID);
        }   
    }
}

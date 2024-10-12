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

    void OnMouseDown()
    {
        var i = taskManag.makeTask(itaskName, itaskObjective, itaskPriority, true, false, itaskType, itaskID);

        taskDisplay.updateTaskDisplay();
    }
}

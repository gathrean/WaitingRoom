using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class taskDisplay : MonoBehaviour
{
    public GameObject taskList;
    public taskManagement taskManag;
    public TextMeshProUGUI taskName;
    public TextMeshProUGUI taskObj;
    public int tasksShown = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateTaskDisplay(string name, string obj)
    {
        taskName.SetText(name);
        taskObj.SetText(obj);
    }
}

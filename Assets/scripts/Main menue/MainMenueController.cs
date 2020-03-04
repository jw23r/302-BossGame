using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenueController : MonoBehaviour
{


    EventSystem events;
    // Start is called before the first frame update
    void Start()
    {
      events =  GetComponentInChildren<EventSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(events.currentSelectedGameObject == null)
        {
            if(events.firstSelectedGameObject != null)
            {
                events.SetSelectedGameObject(events.firstSelectedGameObject);
            }
        }
    }
    public void Button1Pressed()
    {
        print("button 1 was pressed");
    }
    public void Button2Pressed()
    {
        print("button 2 was pressed");
    }
    public void Button3Pressed()
    {
        print("button 3 was pressed");
    }
    public void Button4Pressed()
    {
        print("button 4 was pressed");
    }
    public void Button5Pressed()
    {
        print("button 5 was pressed");
    }
    public void Button6Pressed()
    {
        print("button 6 was pressed");
    }
}

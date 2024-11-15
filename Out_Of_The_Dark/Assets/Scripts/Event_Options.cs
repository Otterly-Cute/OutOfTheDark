using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Event_Options : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    //https://www.youtube.com/watch?v=kkkmX3_fvfQ clicker interfaces/events
    //https://stackoverflow.com/questions/31993266/how-do-i-enable-parts-components-in-unity-c-sharp-with-only-a-game-object-in-the enabling child component

   
   // public Canvas canvas;
    public GameObject plowMenu;
    public GameObject plantingMenu;
    public GameObject cancelMenu;
    public GameObject plantInformationMenu;
    public static int tileStage = 1;

    private void Awake()
    {
       // canvas = gameObject.GetComponentInChildren<Canvas>(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //canvas.enabled = true;
        //Debug.Log("click event");
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (tileStage) 
        {
            case 1:
                plowMenu.SetActive(true); Debug.Log("menu 1"); break;
            case 2:
                plantingMenu.SetActive(true); Debug.Log("menu 2"); break;
            case 3:
                cancelMenu.SetActive(true); Debug.Log("menu 3"); break;
            case 4:
                plantInformationMenu.SetActive(true); Debug.Log("menu 4"); break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

}

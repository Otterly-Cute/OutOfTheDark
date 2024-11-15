using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Event_Options : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler //IPointerEnterHandler, IPointerExitHandler, IDeselectHandler
{
    //https://www.youtube.com/watch?v=kkkmX3_fvfQ clicker interfaces/events
    //https://stackoverflow.com/questions/31993266/how-do-i-enable-parts-components-in-unity-c-sharp-with-only-a-game-object-in-the enabling child component

   
   // public Canvas canvas;
    public GameObject plowMenu;
    public GameObject plantingMenu;
    public GameObject cancelMenu;
    public GameObject plantInformationMenu;
    public static int tileStage = 1;

    private bool mouseIsOver = false;

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

    //public void OnDeselect(BaseEventData eventData)
    //{
    //    //Close the Window on Deselect only if a click occurred outside this panel
    //    if (!mouseIsOver)
    //    {
    //        Debug.Log("Deselcted");
    //        switch (tileStage)
    //        {
    //            case 1:
    //                plowMenu.SetActive(false); Debug.Log("menu 1 off"); break;
    //            case 2:
    //                cancelMenu.SetActive(false); Debug.Log("menu 3 off"); break;
    //            case 3:
    //                plantingMenu.SetActive(false); Debug.Log("menu 2 off"); break;
    //            case 4:
    //                cancelMenu.SetActive(false); Debug.Log("menu 3 off"); break;
    //            case 5:
    //                plantInformationMenu.SetActive(false); Debug.Log("menu 4 off"); break;
    //        }
    //    }
    //}

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (tileStage) 
        {
            case 1:
                plowMenu.SetActive(true); Debug.Log("menu 1"); break;
            case 2:
                cancelMenu.SetActive(true); Debug.Log("menu 3"); break;
            case 3:
                plantingMenu.SetActive(true); Debug.Log("menu 2"); break;
            case 4:
                cancelMenu.SetActive(true); Debug.Log("menu 3"); break;
            case 5:
                plantInformationMenu.SetActive(true); Debug.Log("menu 4"); break;
        }
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    mouseIsOver = true;
    //}

    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    mouseIsOver=false;
    //    Debug.Log("mouse is NOT over");
    //}

}

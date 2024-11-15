using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.EventSystems;

public class Event_Deselect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDeselectHandler
{
    public GameObject plowMenu;
    public GameObject plantingMenu;
    public GameObject cancelMenu;
    public GameObject plantInformationMenu;
    public static int tileStage = 1;

    private bool mouseIsOver = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseIsOver = true;
        Debug.Log("mouse is over");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseIsOver = false;
        Debug.Log("mouse is NOT over");
    }

    public void OnDeselect(BaseEventData eventData)
    {
        //Close the Window on Deselect only if a click occurred outside this panel
        if (!mouseIsOver)
        {
            Debug.Log("Deselcted");
            gameObject.SetActive(false);
            //switch (tileStage)
            //{
            //    case 1:
            //        plowMenu.SetActive(false); Debug.Log("menu 1 off"); break;
            //    case 2:
            //        cancelMenu.SetActive(false); Debug.Log("menu 3 off"); break;
            //    case 3:
            //        plantingMenu.SetActive(false); Debug.Log("menu 2 off"); break;
            //    case 4:
            //        cancelMenu.SetActive(false); Debug.Log("menu 3 off"); break;
            //    case 5:
            //        plantInformationMenu.SetActive(false); Debug.Log("menu 4 off"); break;
            //}
        }
    }

}

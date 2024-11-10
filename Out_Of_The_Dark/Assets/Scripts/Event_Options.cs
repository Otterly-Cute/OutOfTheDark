using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Event_Options : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    //https://www.youtube.com/watch?v=kkkmX3_fvfQ clicker interfaces/events
    //https://stackoverflow.com/questions/31993266/how-do-i-enable-parts-components-in-unity-c-sharp-with-only-a-game-object-in-the enabling child component

   
    public Canvas canvas;

    private void Awake()
    {
        canvas = gameObject.GetComponentInChildren<Canvas>(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        canvas.enabled = true;
        Debug.Log("click event");
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

}

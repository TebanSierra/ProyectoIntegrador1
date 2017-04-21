using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler , IPointerEnterHandler , IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        //if (d != null) {
        //    d.setPlaceHolderParent(this.transform);
        //}
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        //if (d != null)
        //{
        //    d.setPlaceHolderParent(d.getParentToReturn());
        //}
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop to " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            if (this.transform.childCount < 2)
            {
                d.setParentToReturn(this.transform);
            }
        }
    }

}
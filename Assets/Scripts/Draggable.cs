using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour , IBeginDragHandler , IDragHandler , IEndDragHandler {

    Transform ParentToRetornTo;

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");

        ParentToRetornTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        this.transform.position = eventData.position;

        int newSpot = ParentToRetornTo.childCount;
    }

    public void OnEndDrag(PointerEventData eventData) {
        this.transform.SetParent(ParentToRetornTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

    public Transform getParentToReturn()
    {
        return ParentToRetornTo;
    }

    public void setParentToReturn(Transform p)
    {
        ParentToRetornTo = p;
    }
}

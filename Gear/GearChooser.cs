using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class GearChooser : MonoBehaviour, IPointerDownHandler
// click on one gear icon to get gear recommendations
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDownGear");
        
        // when clicked, give a que that player should choose another gear to select for this slot.
        // enable switching gear.
        // give visual que
        
        // enable an event?
        // when another gear is clicked unsub from event?

        // or just switch this to gear objects so they can be moved into other slots? seems like a better way 

        // drag drop handler needed
        // on dragbegin: clone the gear at the same hierarchy, decrease transparency of current gear.
        // on drag: move
        // on dragend: if not in a correct place destroy. if is in a slot increase transparency and trigger slot fitting.
    }
}
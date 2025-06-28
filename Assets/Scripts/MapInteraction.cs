using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Handles user interactions with the attack map.
/// Attach this script to the map GameObject.
/// </summary>
public class MapInteraction : MonoBehaviour, IPointerClickHandler
{
    public AttackMapController attackMapController;

    public void OnPointerClick(PointerEventData eventData)
    {
        Vector3 clickPosition = eventData.pointerCurrentRaycast.worldPosition;
        Debug.Log("Map clicked at: " + clickPosition);

        if (attackMapController != null)
        {
            attackMapController.AddAttackZone(clickPosition);
            // TODO: Show attack details UI
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Controls real-time updates and animations of the attack map.
/// Attach this script to the map GameObject.
/// </summary>
public class MapUpdateController : MonoBehaviour
{
    private AttackMapController attackMapController;

    void Start()
    {
        attackMapController = GetComponent<AttackMapController>();
        if (attackMapController == null)
        {
            Debug.LogError("AttackMapController component not found on MapUpdateController GameObject.");
        }
        StartCoroutine(UpdateMapRoutine());
    }

    IEnumerator UpdateMapRoutine()
    {
        while (true)
        {
            // TODO: Fetch or simulate new attack data
            Vector3 randomPosition = new Vector3(
                Random.Range(-10f, 10f),
                0f,
                Random.Range(-10f, 10f)
            );

            if (attackMapController != null)
            {
                attackMapController.AddAttackZone(randomPosition);
            }

            yield return new WaitForSeconds(5f); // Update every 5 seconds
        }
    }
}

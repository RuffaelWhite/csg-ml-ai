using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Realistic Blue Team AI simulating cybersecurity defense tactics based on MITRE ATT&CK framework.
/// Attach this script to a GameObject representing the Blue Team controller.
/// </summary>
public class BlueAI : MonoBehaviour
{
    public float operationInterval = 10f; // Time between operations in seconds
    private float operationTimer;

    private enum OperationPhase { Monitoring, Detection, Analysis, Containment, Eradication, Recovery, PostIncidentActivity }
    private OperationPhase currentPhase = OperationPhase.Monitoring;

    private Dictionary<OperationPhase, List<string>> tactics = new Dictionary<OperationPhase, List<string>>()
    {
        { OperationPhase.Monitoring, new List<string> { "Network Traffic Analysis", "Log Monitoring", "User Behavior Analytics" } },
        { OperationPhase.Detection, new List<string> { "Signature-Based Detection", "Anomaly Detection", "Threat Hunting" } },
        { OperationPhase.Analysis, new List<string> { "Malware Analysis", "Forensic Analysis", "Incident Correlation" } },
        { OperationPhase.Containment, new List<string> { "Network Segmentation", "Quarantine Infected Systems", "Access Revocation" } },
        { OperationPhase.Eradication, new List<string> { "Malware Removal", "Patch Vulnerabilities", "Credential Reset" } },
        { OperationPhase.Recovery, new List<string> { "System Restoration", "Data Recovery", "Service Restart" } },
        { OperationPhase.PostIncidentActivity, new List<string> { "Lessons Learned", "Security Policy Update", "User Training" } }
    };

    void Start()
    {
        operationTimer = operationInterval;
    }

    void Update()
    {
        operationTimer -= Time.deltaTime;
        if (operationTimer <= 0f)
        {
            PerformOperation();
            operationTimer = operationInterval;
        }
    }

    void PerformOperation()
    {
        if (!tactics.ContainsKey(currentPhase))
        {
            Debug.LogWarning("Unknown operation phase: " + currentPhase);
            currentPhase = OperationPhase.Monitoring;
            return;
        }

        List<string> possibleTactics = tactics[currentPhase];
        string selectedTactic = possibleTactics[Random.Range(0, possibleTactics.Count)];

        Debug.Log($"Blue Team [{currentPhase}] executes tactic: {selectedTactic}");

        // TODO: Implement detailed simulation of the selected tactic

        // Progress to next phase in realistic defense lifecycle
        currentPhase = (OperationPhase)(((int)currentPhase + 1) % System.Enum.GetValues(typeof(OperationPhase)).Length);
    }
}

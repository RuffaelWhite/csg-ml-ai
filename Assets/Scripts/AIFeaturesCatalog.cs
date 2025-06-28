using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Catalog of 50+ real-world AI cybersecurity features for Cybershield Guardian.
/// Each feature includes a name, description, and placeholder for implementation.
/// </summary>
public class AIFeaturesCatalog : MonoBehaviour
{
    public class AIFeature
    {
        public string Name;
        public string Description;
        public bool IsImplemented;

        public AIFeature(string name, string description)
        {
            Name = name;
            Description = description;
            IsImplemented = false;
        }
    }

    public List<AIFeature> Features = new List<AIFeature>();

    void Awake()
    {
        InitializeFeatures();
    }

    void InitializeFeatures()
    {
        Features.Add(new AIFeature("Malware Detection", "Detects malware using signature and behavior analysis."));
        Features.Add(new AIFeature("Phishing Email Detection", "Identifies phishing emails using NLP and heuristics."));
        Features.Add(new AIFeature("Anomaly Detection", "Detects unusual network or user behavior."));
        Features.Add(new AIFeature("Intrusion Detection System (IDS)", "Monitors network traffic for suspicious activity."));
        Features.Add(new AIFeature("Threat Intelligence Correlation", "Correlates threat data from multiple sources."));
        Features.Add(new AIFeature("Vulnerability Assessment", "Identifies system vulnerabilities and risks."));
        Features.Add(new AIFeature("User Behavior Analytics", "Profiles user behavior to detect insider threats."));
        Features.Add(new AIFeature("Network Traffic Analysis", "Analyzes network packets for malicious patterns."));
        Features.Add(new AIFeature("Endpoint Detection and Response (EDR)", "Monitors endpoints for threats and responds."));
        Features.Add(new AIFeature("Automated Incident Response", "Automates response actions to detected threats."));
        Features.Add(new AIFeature("Data Exfiltration Detection", "Detects unauthorized data transfers."));
        Features.Add(new AIFeature("Privilege Escalation Detection", "Identifies attempts to gain elevated privileges."));
        Features.Add(new AIFeature("Malicious URL Detection", "Detects harmful URLs in network traffic."));
        Features.Add(new AIFeature("Botnet Detection", "Identifies botnet command and control communications."));
        Features.Add(new AIFeature("Ransomware Detection", "Detects ransomware behavior and encryption."));
        Features.Add(new AIFeature("Zero-Day Exploit Detection", "Identifies unknown exploit attempts."));
        Features.Add(new AIFeature("Password Attack Detection", "Detects brute force and credential stuffing."));
        Features.Add(new AIFeature("Suspicious Process Monitoring", "Monitors processes for malicious activity."));
        Features.Add(new AIFeature("File Integrity Monitoring", "Detects unauthorized file changes."));
        Features.Add(new AIFeature("DNS Tunneling Detection", "Detects data exfiltration via DNS."));
        Features.Add(new AIFeature("Cloud Security Monitoring", "Monitors cloud environments for threats."));
        Features.Add(new AIFeature("IoT Device Security", "Monitors IoT devices for vulnerabilities."));
        Features.Add(new AIFeature("Malicious Email Attachment Detection", "Detects harmful email attachments."));
        Features.Add(new AIFeature("Social Engineering Detection", "Identifies social engineering attempts."));
        Features.Add(new AIFeature("Network Segmentation Enforcement", "Ensures network segmentation policies."));
        Features.Add(new AIFeature("Security Policy Compliance", "Checks compliance with security policies."));
        Features.Add(new AIFeature("Threat Hunting Automation", "Automates proactive threat hunting."));
        Features.Add(new AIFeature("Security Information and Event Management (SIEM)", "Aggregates and analyzes security events."));
        Features.Add(new AIFeature("Malware Sandbox Analysis", "Analyzes suspicious files in sandbox environment."));
        Features.Add(new AIFeature("Encrypted Traffic Analysis", "Analyzes encrypted network traffic for threats."));
        Features.Add(new AIFeature("Insider Threat Detection", "Detects malicious insider activities."));
        Features.Add(new AIFeature("Phishing Website Detection", "Identifies fraudulent websites."));
        Features.Add(new AIFeature("Threat Actor Profiling", "Profiles threat actors based on behavior."));
        Features.Add(new AIFeature("Cyber Kill Chain Analysis", "Analyzes attack stages and progression."));
        Features.Add(new AIFeature("Malicious Script Detection", "Detects harmful scripts in systems."));
        Features.Add(new AIFeature("Security Orchestration Automation and Response (SOAR)", "Automates security operations."));
        Features.Add(new AIFeature("Network Access Control", "Controls device access to network."));
        Features.Add(new AIFeature("Data Loss Prevention (DLP)", "Prevents unauthorized data leakage."));
        Features.Add(new AIFeature("Threat Feed Integration", "Integrates external threat intelligence feeds."));
        Features.Add(new AIFeature("Behavioral Biometrics", "Uses biometrics for user authentication."));
        Features.Add(new AIFeature("Malware Family Classification", "Classifies malware into families."));
        Features.Add(new AIFeature("Attack Surface Reduction", "Reduces exploitable attack surfaces."));
        Features.Add(new AIFeature("Security Patch Management", "Manages and applies security patches."));
        Features.Add(new AIFeature("Incident Forensics", "Performs forensic analysis post-incident."));
        Features.Add(new AIFeature("Automated Threat Remediation", "Automatically remediates detected threats."));
        Features.Add(new AIFeature("Network Anomaly Detection", "Detects anomalies in network behavior."));
        Features.Add(new AIFeature("Cloud Access Security Broker (CASB)", "Monitors cloud service usage."));
        Features.Add(new AIFeature("Malicious IP Reputation", "Tracks reputation of IP addresses."));
        Features.Add(new AIFeature("Security Awareness Training", "Provides training to users on security."));
        Features.Add(new AIFeature("Multi-Factor Authentication (MFA)", "Enforces MFA for user access."));
        Features.Add(new AIFeature("Threat Intelligence Sharing", "Shares threat data with partners."));
        Features.Add(new AIFeature("Automated Vulnerability Scanning", "Scans systems for vulnerabilities automatically."));
        Features.Add(new AIFeature("Cybersecurity Risk Assessment", "Assesses organizational cybersecurity risks."));
    }
}

using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class MissionParameters {

    public string DestinationName;
    public float DistanceToDestination;

    public string SystemPreview;
    public string SystemImage;

    public int NumberOfProblems;
    public int NumberOfStars;

    public string ConstellationName;
    public string ConstellationInfo;
    public string ConstellationImage;

    public string BriefingText;
    public string DiscoveryInfoText;
    public string SystemDataText;

    public string MissionPatch;

    public string operation;
    public int term0Upper;
    public int term0Lower;
    public int term1Upper;
    public int term1Lower;

    public MissionParameters()
    {
        this.operation = "+";
        this.term0Upper = 9;
        this.term0Lower = 0;
        this.term1Upper = 9;
        this.term1Lower = 0;

        this.DestinationName = "Unknown System";
        this.DistanceToDestination = 0f;

        this.NumberOfProblems = 20;
        this.NumberOfStars = 99;

        this.ConstellationName = "Unknown Constellation";
        this.ConstellationInfo = "No Data Available";
        this.BriefingText = "This is uncharted territory we have no intelligence for you";
        this.DiscoveryInfoText = "Your Sensors are malfunctioning";
        this.SystemDataText = "No Data Available";
    }
}


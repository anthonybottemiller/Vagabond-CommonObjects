using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class Campaign {
    public List<MissionParameters> Missions;
    public string campaignName;

    public Campaign()
    {
        campaignName = "New Campaign";
        this.Missions = new List<MissionParameters>();
    }

    public void NewMission()
    {
        Missions.Add(new MissionParameters());
    }
    public void Load(Stream file)
    // Load Player data from disk
    {
            BinaryFormatter bf = new BinaryFormatter();

            Campaign data = (Campaign)bf.Deserialize(file);
            file.Close();

        // Assign values to object in memory
        Missions = data.Missions;
        campaignName = data.campaignName;
    }
    public void Save(FileStream file)
    // Load Player data from disk
    {
        BinaryFormatter bf = new BinaryFormatter();

        Campaign data = this;

        bf.Serialize(file, data);
        file.Close();

        // Assign values to object in memory
    }
}




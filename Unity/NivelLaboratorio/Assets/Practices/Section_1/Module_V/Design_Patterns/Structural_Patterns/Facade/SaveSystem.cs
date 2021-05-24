using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Singleton;

namespace Practices.Section_1.Module_V.Design_Patterns.Creational_Patterns.Facade
{
    public class SaveSystem : Singleton<SaveSystem>
    {
        private UISaveGame _UISystem;
        private CloudSystem _CloudSystem;
        private PlayerData _PlayerData;
        private ScoreSystem _ScoreSystem;

        public void SaveGame(Player player)
        {
            _UISystem = new UISaveGame();
            _UISystem.DisplaySavedGraphics();

            _PlayerData = new PlayerData();
            _PlayerData.ID = player.GetID();
            _PlayerData.Level = player.GetLevel();

            _ScoreSystem = new ScoreSystem();
            _PlayerData.Score = _ScoreSystem.GetScore(player.GetID());

            SerializePlayerData(_PlayerData, true);
        }

        private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
        {
            string dataFileName = "PlayerInformation.dat";

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = File.Create(Application.persistentDataPath + "/" + dataFileName);
            binaryFormatter.Serialize(fileStream, playerData);
            fileStream.Close();

            if (isCloudSave)
            {
                _CloudSystem = new CloudSystem();
                _CloudSystem.UploadSaveGameToCloud(Application.persistentDataPath + "/" + dataFileName);
            }
        }
    }

}


using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonConnecter : MonoBehaviourPunCallbacks
{
    [SerializeField] private string gameVersion = "0.1";
    [SerializeField] private string nickName = "TestName";
    [SerializeField] private string roomName = "TestRoom";

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.NickName = nickName;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Connect();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            JoinRoom();
        }
    }

    private void Connect()
    {
        Debug.Log("Photon Cloud �ɐڑ����܂��B");
        PhotonNetwork.ConnectUsingSettings();
    }

    private void JoinRoom()
    {
        Debug.Log($"{roomName}�ɎQ�����܂��B");
        PhotonNetwork.JoinOrCreateRoom(roomName, new RoomOptions(), TypedLobby.Default);
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Photon Cloud �ɐڑ����܂����B");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log($"{roomName} �ɎQ�����܂����B");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log($"{newPlayer.NickName} ���������܂����B");
    }
}

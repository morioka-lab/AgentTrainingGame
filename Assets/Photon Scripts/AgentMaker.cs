using Photon.Pun;
using UnityEngine;

public class NetworkCubeMaker : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject RollerAgent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            PhotonNetwork.Instantiate(RollerAgent.name, Vector3.zero, Quaternion.identity, 0);
        }
    }
}

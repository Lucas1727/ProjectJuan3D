using Mirror;
using UnityEngine;

public class Level_Initialization : NetworkBehaviour
{
    GameObject playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Instantiate(Resources.Load("PreFabs/PlayerLook") as GameObject);
    }

    public GameObject getPlayerCamera()
    {
        return playerCamera;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

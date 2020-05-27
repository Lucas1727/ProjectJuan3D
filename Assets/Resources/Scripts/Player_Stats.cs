using Mirror;
using UnityEngine;

public class Player_Stats : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<Player_Movement>().playerCam = GameObject.FindObjectOfType<Level_Initialization>().getPlayerCamera().transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

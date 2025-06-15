using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : SaiBehaviour
{
    public List<PlayerCtrl> players = new();
    private int currentPlayerIndex = 0;

    protected override void Start()
    {
        base.Start();
        LoadPlayer();
        SwitchToPlayer(0);
    }

    protected virtual void LoadPlayer()
    {
        if (this.players.Count > 0) return;

        foreach (Transform child in transform)
        {
            PlayerCtrl playerCtrl = child.GetComponent<PlayerCtrl>();
            if (playerCtrl != null)
                this.players.Add(playerCtrl);
        }

        Debug.LogWarning(transform.name + ": Loaded Players", gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            int nextIndex = (currentPlayerIndex + 1) % players.Count;
            SwitchToPlayer(nextIndex);
        }
    }

    private void SwitchToPlayer(int newIndex)
    {
        if (newIndex == currentPlayerIndex) return;

        Vector3 currentPosition = players[currentPlayerIndex].transform.position;
        Quaternion currentRotation = players[currentPlayerIndex].transform.rotation;

        players[currentPlayerIndex].gameObject.SetActive(false);

        currentPlayerIndex = newIndex;

        players[currentPlayerIndex].transform.position = currentPosition;
        players[currentPlayerIndex].transform.rotation = currentRotation;

        players[currentPlayerIndex].gameObject.SetActive(true);

        CamFollow cam = Camera.main.GetComponent<CamFollow>();
        if (cam != null)
        {
            cam.SetMainTarget(players[currentPlayerIndex].transform);
        }

        Debug.Log("Switched to player: " + players[currentPlayerIndex].name);
    }
}

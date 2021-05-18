using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    private List<CheckpointSingle> checkpointSingleList;
    private int nextCheckpointSingleIndex;
    public GameObject end;

    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");
        checkpointSingleList = new List<CheckpointSingle>();

        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackCheckpoints(this);
            checkpointSingleList.Add(checkpointSingle);
        }

        nextCheckpointSingleIndex = 0;
    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle)
    {
        if (checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            Debug.Log("Correct");
            checkpointSingle.transform.gameObject.SetActive(false);
            if(nextCheckpointSingleIndex == checkpointSingleList.Count - 1)
            {
                end.SetActive(true);
            }
            else
            {
                nextCheckpointSingleIndex++;
                checkpointSingleList[nextCheckpointSingleIndex].transform.gameObject.SetActive(true);
            }
        }
    }
}

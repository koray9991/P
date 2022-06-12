using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject[] Participants;
    public float[] ParticipantsTransformZ;
    public float[] QueuePTZ;
    public Text T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11;
   
    int i, j;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ParticipantsTransformZ[0] = Participants[0].transform.position.z;
        ParticipantsTransformZ[1] = Participants[1].transform.position.z;
        ParticipantsTransformZ[2] = Participants[2].transform.position.z;
        ParticipantsTransformZ[3] = Participants[3].transform.position.z;
        ParticipantsTransformZ[4] = Participants[4].transform.position.z;
        ParticipantsTransformZ[5] = Participants[5].transform.position.z;
        ParticipantsTransformZ[6] = Participants[6].transform.position.z;
        ParticipantsTransformZ[7] = Participants[7].transform.position.z;
        ParticipantsTransformZ[8] = Participants[8].transform.position.z;
        ParticipantsTransformZ[9] = Participants[9].transform.position.z;
        ParticipantsTransformZ[10] = Participants[10].transform.position.z;




       


        for (i = 0; i < QueuePTZ.Length; i++)
        {
            for (j = 1; j < QueuePTZ.Length - i; j++)
            {
                if (QueuePTZ[j - 1] > QueuePTZ[j])
                {
                    float temp = QueuePTZ[j];
                    QueuePTZ[j] = QueuePTZ[j - 1];
                    QueuePTZ[j - 1] = temp;
                }
            }
        }

        



        //FOR P10
        #region
        if (ParticipantsTransformZ[10] == QueuePTZ[0])
        {
            T11.text = Participants[10].transform.name;
            T11.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[1])
        {
            T10.text = Participants[10].transform.name;
            T10.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[2])
        {
            T9.text = Participants[10].transform.name;
            T9.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[3])
        {
            T8.text = Participants[10].transform.name;
            T8.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[4])
        {
            T7.text = Participants[10].transform.name;
            T7.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[5])
        {
            T6.text = Participants[10].transform.name;
            T6.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[6])
        {
            T5.text = Participants[10].transform.name;
            T5.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[7])
        {
            T4.text = Participants[10].transform.name;
            T4.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[8])
        {
            T3.text = Participants[10].transform.name;
            T3.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[9])
        {
            T2.text = Participants[10].transform.name;
            T2.color = Color.blue;
        }
        if (ParticipantsTransformZ[10] == QueuePTZ[10])
        {
            T1.text = Participants[10].transform.name;
            T1.color = Color.blue;
        }
        #endregion
        //FOR P9
        #region
        if (ParticipantsTransformZ[9] == QueuePTZ[0])
        {
            T11.text = Participants[9].transform.parent.name;
            T11.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[1])
        {
            T10.text = Participants[9].transform.parent.name;
            T10.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[2])
        {
            T9.text = Participants[9].transform.parent.name;
            T9.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[3])
        {
            T8.text = Participants[9].transform.parent.name;
            T8.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[4])
        {
            T7.text = Participants[9].transform.parent.name;
            T7.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[5])
        {
            T6.text = Participants[9].transform.parent.name;
            T6.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[6])
        {
            T5.text = Participants[9].transform.parent.name;
            T5.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[7])
        {
            T4.text = Participants[9].transform.parent.name;
            T4.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[8])
        {
            T3.text = Participants[9].transform.parent.name;
            T3.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[9])
        {
            T2.text = Participants[9].transform.parent.name;
            T2.color = Color.white;
        }
        if (ParticipantsTransformZ[9] == QueuePTZ[10])
        {
            T1.text = Participants[9].transform.parent.name;
            T1.color = Color.white;
        }
        #endregion
        //FOR P8
        #region
        if (ParticipantsTransformZ[8] == QueuePTZ[0])
        {
            T11.text = Participants[8].transform.parent.name;
            T11.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[1])
        {
            T10.text = Participants[8].transform.parent.name;
            T10.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[2])
        {
            T9.text = Participants[8].transform.parent.name;
            T9.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[3])
        {
            T8.text = Participants[8].transform.parent.name;
            T8.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[4])
        {
            T7.text = Participants[8].transform.parent.name;
            T7.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[5])
        {
            T6.text = Participants[8].transform.parent.name;
            T6.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[6])
        {
            T5.text = Participants[8].transform.parent.name;
            T5.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[7])
        {
            T4.text = Participants[8].transform.parent.name;
            T4.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[8])
        {
            T3.text = Participants[8].transform.parent.name;
            T3.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[9])
        {
            T2.text = Participants[8].transform.parent.name;
            T2.color = Color.white;
        }
        if (ParticipantsTransformZ[8] == QueuePTZ[10])
        {
            T1.text = Participants[8].transform.parent.name;
            T1.color = Color.white;
        }
        #endregion
        //FOR P7
        #region
        if (ParticipantsTransformZ[7] == QueuePTZ[0])
        {
            T11.text = Participants[7].transform.parent.name;
            T11.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[1])
        {
            T10.text = Participants[7].transform.parent.name;
            T10.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[2])
        {
            T9.text = Participants[7].transform.parent.name;
            T9.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[3])
        {
            T8.text = Participants[7].transform.parent.name;
            T8.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[4])
        {
            T7.text = Participants[7].transform.parent.name;
            T7.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[5])
        {
            T6.text = Participants[7].transform.parent.name;
            T6.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[6])
        {
            T5.text = Participants[7].transform.parent.name;
            T5.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[7])
        {
            T4.text = Participants[7].transform.parent.name;
            T4.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[8])
        {
            T3.text = Participants[7].transform.parent.name;
            T3.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[9])
        {
            T2.text = Participants[7].transform.parent.name;
            T2.color = Color.white;
        }
        if (ParticipantsTransformZ[7] == QueuePTZ[10])
        {
            T1.text = Participants[7].transform.parent.name;
            T1.color = Color.white;
        }
        #endregion
        //FOR P6
        #region
        if (ParticipantsTransformZ[6] == QueuePTZ[0])
        {
            T11.text = Participants[6].transform.parent.name;
            T11.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[1])
        {
            T10.text = Participants[6].transform.parent.name;
            T10.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[2])
        {
            T9.text = Participants[6].transform.parent.name;
            T9.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[3])
        {
            T8.text = Participants[6].transform.parent.name;
            T8.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[4])
        {
            T7.text = Participants[6].transform.parent.name;
            T7.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[5])
        {
            T6.text = Participants[6].transform.parent.name;
            T6.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[6])
        {
            T5.text = Participants[6].transform.parent.name;
            T5.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[7])
        {
            T4.text = Participants[6].transform.parent.name;
            T4.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[8])
        {
            T3.text = Participants[6].transform.parent.name;
            T3.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[9])
        {
            T2.text = Participants[6].transform.parent.name;
            T2.color = Color.white;
        }
        if (ParticipantsTransformZ[6] == QueuePTZ[10])
        {
            T1.text = Participants[6].transform.parent.name;
            T1.color = Color.white;
        }
        #endregion
        //FOR P5
        #region
        if (ParticipantsTransformZ[5] == QueuePTZ[0])
        {
            T11.text = Participants[5].transform.parent.name;
            T11.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[1])
        {
            T10.text = Participants[5].transform.parent.name;
            T10.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[2])
        {
            T9.text = Participants[5].transform.parent.name;
            T9.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[3])
        {
            T8.text = Participants[5].transform.parent.name;
            T8.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[4])
        {
            T7.text = Participants[5].transform.parent.name;
            T7.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[5])
        {
            T6.text = Participants[5].transform.parent.name;
            T6.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[6])
        {
            T5.text = Participants[5].transform.parent.name;
            T5.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[7])
        {
            T4.text = Participants[5].transform.parent.name;
            T4.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[8])
        {
            T3.text = Participants[5].transform.parent.name;
            T3.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[9])
        {
            T2.text = Participants[5].transform.parent.name;
            T2.color = Color.white;
        }
        if (ParticipantsTransformZ[5] == QueuePTZ[10])
        {
            T1.text = Participants[5].transform.parent.name;
            T1.color = Color.white;
        }
        #endregion
        //FOR P4
        #region
        if (ParticipantsTransformZ[4] == QueuePTZ[0])
        {
            T11.text = Participants[4].transform.parent.name;
            T11.color = Color.white;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[1])
        {
            T10.text = Participants[4].transform.parent.name;
            T10.color = Color.white;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[2])
        {
            T9.text = Participants[4].transform.parent.name;
            T9.color = Color.white;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[3])
        {
            T8.text = Participants[4].transform.parent.name;
            T8.color = Color.white;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[4])
        {
            T7.text = Participants[4].transform.parent.name;
            T7.color = Color.white;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[5])
        {
            T6.color = Color.white;
            T6.text = Participants[4].transform.parent.name;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[6])
        {
            T5.color = Color.white;
            T5.text = Participants[4].transform.parent.name;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[7])
        {
            T4.color = Color.white;
            T4.text = Participants[4].transform.parent.name;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[8])
        {
            T3.color = Color.white;
            T3.text = Participants[4].transform.parent.name;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[9])
        {
            T2.color = Color.white;
            T2.text = Participants[4].transform.parent.name;
        }
        if (ParticipantsTransformZ[4] == QueuePTZ[10])
        {
            T1.color = Color.white;
            T1.text = Participants[4].transform.parent.name;
        }
        #endregion
        //FOR P3
        #region
        if (ParticipantsTransformZ[3] == QueuePTZ[0])
        {
            T11.color = Color.white;
            T11.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[1])
        {
            T10.color = Color.white;
            T10.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[2])
        {
            T9.color = Color.white;
            T9.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[3])
        {
            T8.color = Color.white;
            T8.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[4])
        {
            T7.color = Color.white;
            T7.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[5])
        {
            T6.color = Color.white;
            T6.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[6])
        {
            T5.color = Color.white;
            T5.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[7])
        {
            T4.color = Color.white;
            T4.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[8])
        {
            T3.color = Color.white;
            T3.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[9])
        {
            T2.color = Color.white;
            T2.text = Participants[3].transform.parent.name;
        }
        if (ParticipantsTransformZ[3] == QueuePTZ[10])
        {
            T1.color = Color.white;
            T1.text = Participants[3].transform.parent.name;
        }
        #endregion
        //FOR P2
        #region
        if (ParticipantsTransformZ[2] == QueuePTZ[0])
        {
            T11.color = Color.white;
            T11.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[1])
        {
            T10.color = Color.white;
            T10.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[2])
        {
            T9.color = Color.white;
            T9.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[3])
        {
            T8.color = Color.white;
            T8.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[4])
        {
            T7.color = Color.white;
            T7.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[5])
        {
            T6.color = Color.white;
            T6.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[6])
        {
            T5.color = Color.white;
            T5.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[7])
        {
            T4.color = Color.white;
            T4.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[8])
        {
            T3.color = Color.white;
            T3.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[9])
        {
            T2.color = Color.white;
            T2.text = Participants[2].transform.parent.name;
        }
        if (ParticipantsTransformZ[2] == QueuePTZ[10])
        {
            T1.color = Color.white;
            T1.text = Participants[2].transform.parent.name;
        }
        #endregion
        //FOR P1
        #region
        if (ParticipantsTransformZ[1] == QueuePTZ[0])
        {
            T11.color = Color.white;
            T11.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[1])
        {
            T10.color = Color.white;
            T10.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[2])
        {
            T9.color = Color.white;
            T9.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[3])
        {
            T8.color = Color.white;
            T8.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[4])
        {
            T7.color = Color.white;
            T7.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[5])
        {
            T6.color = Color.white;
            T6.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[6])
        {
            T5.color = Color.white;
            T5.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[7])
        {
            T4.color = Color.white;
            T4.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[8])
        {
            T3.color = Color.white;
            T3.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[9])
        {
            T2.color = Color.white;
            T2.text = Participants[1].transform.parent.name;
        }
        if (ParticipantsTransformZ[1] == QueuePTZ[10])
        {
            T1.color = Color.white;
            T1.text = Participants[1].transform.parent.name;
        }
        #endregion
        //FOR P0
        #region
        if (ParticipantsTransformZ[0] == QueuePTZ[0])
        {
            T11.color = Color.white;
            T11.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[1])
        {
            T10.color = Color.white;
            T10.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[2])
        {
            T9.color = Color.white;
            T9.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[3])
        {
            T8.color = Color.white;
            T8.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[4])
        {
            T7.color = Color.white;
            T7.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[5])
        {
            T6.color = Color.white;
            T6.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[6])
        {
            T5.color = Color.white;
            T5.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[7])
        {
            T4.color = Color.white;
            T4.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[8])
        {
            T3.color = Color.white;
            T3.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[9])
        {
            T2.color = Color.white;
            T2.text = Participants[0].transform.parent.name;
        }
        if (ParticipantsTransformZ[0] == QueuePTZ[10])
        {
            T1.color = Color.white;
            T1.text = Participants[0].transform.parent.name;
        }
        #endregion

        QueuePTZ[0] = Participants[0].transform.position.z;
        QueuePTZ[1] = Participants[1].transform.position.z;
        QueuePTZ[2] = Participants[2].transform.position.z;
        QueuePTZ[3] = Participants[3].transform.position.z;
        QueuePTZ[4] = Participants[4].transform.position.z;
        QueuePTZ[5] = Participants[5].transform.position.z;
        QueuePTZ[6] = Participants[6].transform.position.z;
        QueuePTZ[7] = Participants[7].transform.position.z;
        QueuePTZ[8] = Participants[8].transform.position.z;
        QueuePTZ[9] = Participants[9].transform.position.z;
        QueuePTZ[10] = Participants[10].transform.position.z;
    }
}

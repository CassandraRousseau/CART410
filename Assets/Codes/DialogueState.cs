using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogue { 
public class DialogueState : MonoBehaviour
{

        public Dictionary<string, string> stateDict;
    // Start is called before the first frame update
    private void Start()
    {
        stateDict = new Dictionary<string, string>();
    }

}
}

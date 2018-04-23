using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewtonsLawsText : MonoBehaviour
{
    string[] laws =
    {
        "1) If a body is at rest it remains at rest or, if it is in motion, it moves with uniform velocity, until it is acted on by a net force.",
        "2) For a particle of mass m, the net force F on the particle is equal to the mass m times the particle's acceleration a: F = ma",
        "3) For every action, there is an equal and opposite reaction.    Or every action always reacts in the opposite direction.",
    };
    int index = 0;
    public Text text;
    public void Next()
    {
        index = (index + 1) % laws.Length;
        text.text = laws[index];
    }
}
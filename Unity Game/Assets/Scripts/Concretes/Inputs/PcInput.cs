using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGame.Abstracts.Inputs;

namespace UnityGame.Inputs
{
    public class PcInput : IPlayerInputs
    {

        public float Horizontal => Input.GetAxis("Horizontal");

        public float Vertical => Input.GetAxis("Vertical");
    }
}


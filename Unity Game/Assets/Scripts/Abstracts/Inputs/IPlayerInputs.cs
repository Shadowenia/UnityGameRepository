using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame.Abstracts.Inputs
{
    public interface IPlayerInputs
    {
        float Horizontal { get; }
        float Vertical { get; }
    }
}


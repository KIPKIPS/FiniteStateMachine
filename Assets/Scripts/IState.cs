﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {
    void Execute(PlayerController playerController);
}

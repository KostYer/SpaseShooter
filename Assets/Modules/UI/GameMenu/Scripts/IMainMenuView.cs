﻿using System;

namespace Game.UI
{
    public interface IMainMenuView
    {
        event Action OnStartButtonPressed;
        event Action OnQuitButtonPressed;
    }
}


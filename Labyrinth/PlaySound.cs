﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace Labyrinth
{
    public static class PlaySound
    {
        public static bool MusicOn = true;
        
        public static void PlayMusic(Sound aSound)
        {
            if (MusicOn)
            {
                SoundPlayer _player = new SoundPlayer(Properties.Resources.ResourceManager.GetStream(aSound.ToString()));
                _player.Play();
            }
        }
        
    }
    public enum Sound
    {
        fail,
        finish,
        key,
        start,
        victory
    }
}

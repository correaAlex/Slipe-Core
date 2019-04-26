﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Peds;
using Slipe.Client.SightLines;
using Slipe.Shared.Peds;
using System.Numerics;
using Slipe.Shared.Helpers;
using System.Timers;
using Slipe.Shared.Elements;

namespace ClientSide
{
    class Follower : Ped
    {
        private Player player;
        private SightLine[] sightLines;

        public Follower(Player player)
            : base(PedModel.cj, player.Position + player.ForwardVector * -4)
        {
            this.player = player;            
            sightLines = new SightLine[10];

            for (int i=0; i <= 9; i++)
            {
                SightLine s = new SightLine(this, new Vector3(0, 1, -0.5f + i * 0.2f), Matrix4x4.Identity);
                s.CheckPeds = false;                
                s.Debug = true; // For debug purposes, we draw the line
                sightLines[i] = s;
            }

            Timer updateTimer = new Timer(50);
            updateTimer.Elapsed += Update;
            updateTimer.Enabled = true;
        }

        private void Update(Object source, ElapsedEventArgs e)
        {
            // Calculate the distance between the follower and the player
            float distance = Vector3.Distance(player.Position, Position);
            SetControlState(AnalogControl.forwards, distance >= 4);

            if (distance < 4)
                return;

            // Make the ped face the player
            FaceElement(player);

            // Loop through all the sightlines to see if one collides
            bool clear = true;
            foreach(SightLine s in sightLines)
            {
                clear = s.IsClear;
                if (!clear)
                    break;
            }

            // Check if everything is clear
            SetControlState(AnalogControl.jump, !clear);

            // Run if the player is too far away
            SetControlState(AnalogControl.sprint, distance > 15);
        }

    }
}
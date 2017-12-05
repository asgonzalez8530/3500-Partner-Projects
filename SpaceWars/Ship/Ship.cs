﻿// Anastasia Gonzalez and Aaron Bellis UID: u0985898 & u0981638
// Code implemented as part of PS7 : SpaceWars client CS3500 Fall Semester
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpaceWars
{
    /// <summary>
    /// Represents a ship object in a SpaceWars game. Provides information about
    /// location, direction and game scoring.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Ship
    {
        [JsonProperty(PropertyName = "ship")]
        private int ID; // unique ID for the ship

        [JsonProperty]
        private Vector2D loc; // current location of the ship in the world

        [JsonProperty]
        private Vector2D dir; // dirction that the ship is headed in the world

        [JsonProperty]
        private bool thrust; // True if thrusts on the ship are on 

        [JsonProperty]
        private string name; // name of the user 

        [JsonProperty]
        private int hp; // health points for the ship

        [JsonProperty]
        private int score; // amount of ship's the current ship had shot down

        private int width = 65; // image width in pixels

        private int height = 100; // image height in pixels

        /// <summary>
        /// Default construtor, needed to deserialize a ship from Json
        /// initializes a Ship object with no parameters set.
        /// </summary>
        public Ship()
        {

        }

        /// <summary>
        /// Creates a new ship with the given ship name and id at loc (0,0) and
        /// with a direction (0,0)
        /// </summary>
        public Ship(String shipName, int id)
            :this(shipName, id, new Vector2D(0, 0), new Vector2D(0, 0))
        {
            
        }

        /// <summary>
        /// Creates a new ship with the given ship name and id and located at
        /// the specified location and orientation
        /// </summary>
        public Ship(String shipName, int id, Vector2D location, Vector2D orientation)
        {
            ID = id;
            name = shipName;

            loc = location;
            dir = orientation;
            dir.Normalize();

            thrust = false;
            hp = 5;
            score = 0;
        }

        public bool TurnRight { get; set; }
        public bool TurnLeft { get; set; }
        public bool FireProjectile { get; set; }
        public bool Thrust { get => thrust; set => thrust = value; }

        /// <summary>
        /// Get the ship's ID
        /// </summary>
        public int GetID()
        {
            return ID;
        }

        /// <summary>
        /// Get the ship's location
        /// </summary>
        public Vector2D GetLocation()
        {
            return loc;
        }

        /// <summary>
        /// Get the direction of the ship
        /// </summary>
        public Vector2D GetDirection()
        {
            return dir;
        }

        /// <summary>
        /// if the ship has thrust then return true otherwise return false
        /// </summary>
        public bool HasThrust()
        {
            return thrust;
        }

        /// <summary>
        /// Gets the name of the ship
        /// </summary>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Get the ship's hp 
        /// </summary>
        public int GetHP()
        {
            return hp;
        }

        /// <summary>
        /// Gets the ship's score 
        /// </summary>
        public int GetScore()
        {
            return score;
        }

        /// <summary>
        /// Gets the images width in pixels
        /// </summary>
        public int GetWidth()
        {
            return width;
        }

        /// <summary>
        /// Gets the image height in pixels
        /// </summary>
        public int GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Returns true if the ship's health points are above 0. Otherwise, returns false.
        /// </summary>
        public bool IsAlive()
        {
            return (hp > 0);
        }
    }
}

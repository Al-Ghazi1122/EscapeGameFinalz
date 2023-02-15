using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeGame
{
    internal class RoomClass
    {
        protected string RoomName { get; set; }
        protected string RoomDescription { get; set; }
        protected string LightStatus { get; set; }

        public RoomClass()
        {
            RoomName = "Room1";
            RoomDescription = "This is a room";
            LightStatus = "on";
        }
        public RoomClass(string name, string description = "There is no description", string light = "on")
        {
            RoomName = name;
            RoomDescription = description;
            LightStatus = light;
        }
        public virtual string getRoomDetails() //Room Description
        {
            return ("You are in " + RoomName + ". " + RoomDescription + ". The light is " + LightStatus);
        }
        public string setLightStatus()
        {
            if (LightStatus == "off")
            { LightStatus = "on"; }
            else
            { LightStatus = "off"; }
            return ("The light is now " + LightStatus);
        }
    }// End of Room Class

    class StoreRoom : RoomClass
    {
        private string DoorStatus { get; set; }

        public StoreRoom()
        {
            RoomName = "Store1";
            RoomDescription = "This is a storeroom";
            LightStatus = "off";
            DoorStatus = "closed";
        }
        public StoreRoom(string name, string description, string light = "off", string door = "closed")
        {
            RoomName = name;
            RoomDescription = description;
            LightStatus = light;
            DoorStatus = door;
        }
        public string setDoorStatus()
        {
            if (DoorStatus == "closed")
            { DoorStatus = "open"; }
            else
            { DoorStatus = "closed"; }
            return ("The light is now " + DoorStatus);
        }
        public override string getRoomDetails()
        {
            base.getRoomDetails();
            return (RoomDescription + ". The light is " + LightStatus + "and there is a door that is " + DoorStatus);
        }
    }// End of Storeroom Class

    class Kitchen : RoomClass
    {
        private string StoreDoor1Status { get; set; }
        private string StoreDoor2Status { get; set; }
        private string LivingRoom1DoorStatus { get; set; }

        public Kitchen()
        {
            RoomName = "Kitchen1";
            RoomDescription = "This is a kitchen";
            LightStatus = "off";
            StoreDoor1Status = "open";
            StoreDoor2Status = "closed";
            LivingRoom1DoorStatus = "locked";
        }
        public Kitchen(string name, string description, string light = "off", string sDoor = "open", string sDoor2 = "closed", string lDoor1 = "locked")
        {
            RoomName = name;
            RoomDescription = description;
            LightStatus = light;
            StoreDoor1Status = sDoor;
            StoreDoor2Status = sDoor2;
            LivingRoom1DoorStatus = lDoor1;
        }
        public string setStoreDoor1Status()
        {
            if (StoreDoor1Status == "closed")
            { StoreDoor1Status = "open"; }
            else
            { StoreDoor1Status = "closed"; }
            return ("The door is now " + StoreDoor1Status);
        }
        public string setStoreDoor2Status()
        {
            if (StoreDoor1Status == "closed")
            { StoreDoor1Status = "open"; }
            else
            { StoreDoor1Status = "closed"; }
            return ("The door is now " + StoreDoor1Status);
        }
        public string setLivingRoomDoorStatus(bool hasKey)
        {
            string returnString = "";
            if (StoreDoor1Status == "locked")
            {
                returnString = (returnString + "A blue key is needed to open this door. ");
                if (hasKey)
                {
                    returnString = (returnString + "You have used the key to unlock the door. ");
                    StoreDoor1Status = "open";
                }
            }
            else if (StoreDoor1Status == "closed")
            { StoreDoor1Status = "open"; }
            else
            { StoreDoor1Status = "closed"; }

            return ("The door is " + StoreDoor1Status + ". " + returnString);
        }
    }//End of Kitchen Class

    class LivingRoom : RoomClass
    {
        private string KitchenDoor1Status { get; set; }
        private string ExitDoorStatus { get; set; }


        public LivingRoom()
        {
            RoomName = "Store1";
            RoomDescription = "This is a livingroom";
            LightStatus = "off";
            KitchenDoor1Status = "open";
            ExitDoorStatus = "locked";
        }
        public LivingRoom(string name, string description, string light = "off", string kDoor = "open", string eDoor = "locked")
        {
            RoomName = name;
            RoomDescription = description;
            LightStatus = light;
            KitchenDoor1Status = kDoor;
            ExitDoorStatus = eDoor;
        }
        public string setKitchenDoor1Status()
        {
            if (KitchenDoor1Status == "closed")
            { KitchenDoor1Status = "open"; }
            else
            { KitchenDoor1Status = "closed"; }
            return ("The door is now " + KitchenDoor1Status);
        }
        public string setExitDoorStatus(bool hasKey)
        {
            string returnString = "";
            if (ExitDoorStatus == "locked")

            {
                if (hasKey)

                {
                    returnString = "You have used the key to unlock the door.";
                    ExitDoorStatus = "open";
                }
            }
            else if (ExitDoorStatus == "closed")
            { ExitDoorStatus = "open"; }
            else
            { ExitDoorStatus = "closed"; }

            return ("The door is " + ExitDoorStatus + ". " + returnString);
        }
    }
}
//End of Living room Class


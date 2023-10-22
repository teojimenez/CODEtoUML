using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalStore
{
    public abstract class Product
    {
        public int id;
        public string name;
        public float basePrice;
        public float discount;
        public string description;
        public DateTime release;

        public List<Media> media;
        public bool Buy(int user)
        {
            return true;
        }
        public string Download()
        {
            return "";
        }
    }

    public abstract class Software : Product
    {
        public Company developer;
        private bool Update()
        {
            return true;
        }
    }
    public class Game : Software
    {
        public Company publisher;
        public List<DLC> dlcs;
    }
    public class DLC : Software
    {

    }
    public class Tool : Software
    {
        public enum TYPE { Photo, Video, Engine, Other}
        public TYPE type;
    }
}
